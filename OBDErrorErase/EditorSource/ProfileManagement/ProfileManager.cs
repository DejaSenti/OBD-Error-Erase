using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Utils;
using System.Text.Json;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile? CurrentProfile { get; private set; }

        public int CurrentSubProfileIndex { get; private set; } = -1;
        
        public SubprofileData? CurrentSubProfile => CurrentProfile == null || CurrentSubProfileIndex == -1
            ? null 
            : CurrentProfile.Subprofiles[CurrentSubProfileIndex];

        private UniqueNameContainer nameContainer;

        private Dictionary<string, int> fileCountByManufacturer = new();

        public IReadOnlyList<string> ProfileIDs => nameContainer.TakenNames;

        public ProfileManager()
        {
            var existingProfileIDs = AppFileHelper.GetAllFilesInAppSubFolder(AppFolderNames.PROFILES)
                .Select(fileInfo => Path.GetFileNameWithoutExtension(fileInfo.Name))
                .ToArray();

            nameContainer = new UniqueNameContainer(string.Empty);
            nameContainer.TakeNames(existingProfileIDs);

            InitializeFileCountByManufacturerLookup(existingProfileIDs);
        }

        private void InitializeFileCountByManufacturerLookup(string[] allProfileIDs)
        {
            foreach (var id in allProfileIDs)
            {
                var profile = LoadProfile(id);

                var currentCount = fileCountByManufacturer.GetValueOrDefault(profile.Manufacturer);

                fileCountByManufacturer[profile.Manufacturer] = currentCount + 1;
            }
        }

        public string[] GetManufacturers()
        {
            return fileCountByManufacturer.Keys.ToArray();
        }

        public Profile CreateNewProfile(
            ProfileType type = ProfileType.BOSCH, 
            string manufacturer = ProfileStrings.DEFAULT_MANUFACTURER_NAME,
            string name = ProfileStrings.DEFAULT_PROFILE_NAME)
        {
            var profile = new Profile(type, manufacturer, name);

            profile.PopulateDefaults();

            profile.ClearDirty(); //safety against dirty new profiles

            UpdateProfileID(profile, true);

            return profile;
        }

        public void SetCurrentProfile(Profile profile)
        {
            CurrentProfile = profile;

            CurrentSubProfileIndex = profile.Subprofiles.Count > 0 ? 0 : -1;
        }

        internal Profile? DuplicateCurrentProfile()
        {
            if (CurrentProfile == null)
                return null;

            var serialized = JsonSerializer.Serialize(CurrentProfile);
            var copy = JsonSerializer.Deserialize<Profile>(serialized);

            if (copy == null)
                return null;

            UpdateProfileID(copy, true);

            return copy;
        }

        public void RemoveProfile(string id)
        {
            var profile = LoadProfile(id);
            nameContainer.ReleaseNames(profile.ID);
            SubtractFromManufacturer(profile.Manufacturer);
            AppFileHelper.RemoveFile(AppFolderNames.PROFILES, profile.ID);
        }

        public Profile LoadProfile(string id)
        {
            var profileContents = AppFileHelper.LoadStringFile(AppFolderNames.PROFILES, id);
            var result = JsonSerializer.Deserialize<Profile>(profileContents);
#pragma warning disable CS8603 // Possible null reference return. (should never be, LoadStringFile is safe in that regard, and if we crash, let us burrrrnnn)
            return result;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void SaveProfile(Profile profile, bool ignoreDirty = false)
        {
            if (!ignoreDirty && !profile.IsDirty)
                return;

            var options = new JsonSerializerOptions { WriteIndented = true };
            var serialized = JsonSerializer.Serialize(profile, options);
            AppFileHelper.SaveStringFile(serialized, AppFolderNames.PROFILES, profile.ID);

            profile.ClearDirty();
        }

        internal void SaveCurrentProfile()
        {
            if (CurrentProfile == null)
                throw new Exception("Can't save current profile because it is null.");

            SaveProfile(CurrentProfile);
        }

        public void SetCurrentProfileManufacturer(string newManufacturer)
        {
            if (CurrentProfile == null)
                return;

            AppFileHelper.RemoveFile(AppFolderNames.PROFILES, CurrentProfile.ID);

            SubtractFromManufacturer(CurrentProfile.Manufacturer);

            CurrentProfile.Manufacturer = newManufacturer;

            AddToManufacturer(CurrentProfile.Manufacturer);

            UpdateProfileID(CurrentProfile);
        }

        public void SetCurrentProfileName(string newName)
        {
            if (CurrentProfile == null)
                return;

            CurrentProfile.Name = newName;

            UpdateProfileID(CurrentProfile);
        }

        internal void ChangeCurrentProfileType(ProfileType newType)
        {
            if (CurrentProfile == null)
                return;

            var profile = CreateNewProfile(newType, CurrentProfile.Manufacturer, CurrentProfile.Name);

            CurrentProfile = profile;
        }

        public void SetCurrentSubprofile(int newIndex)
        {
            if (CurrentProfile == null)
                return;

            CurrentSubProfileIndex = newIndex;
        }

        public void SetCurrentSubprofile(SubprofileData? subprofile)
        {
            if (CurrentProfile == null || subprofile == null)
                return;

            SetCurrentSubprofile(CurrentProfile.Subprofiles.IndexOf(subprofile));
        }

        public void DuplicateCurrentSubprofile()
        {
            if (CurrentProfile == null || CurrentSubProfileIndex == -1)
                return;

            var serialized = JsonSerializer.Serialize(CurrentProfile.Subprofiles[CurrentSubProfileIndex]);
            var copy = JsonSerializer.Deserialize<SubprofileData>(serialized);

            if (copy == null)
                return;

            CurrentProfile.Subprofiles.Add(copy);
        }

        public void RemoveCurrentSubProfile()
        {
            if (CurrentProfile == null || CurrentSubProfileIndex == -1)
                return;

            CurrentProfile.Subprofiles.RemoveAt(CurrentSubProfileIndex);

            CurrentSubProfileIndex = -1;
        }

        private void UpdateProfileID(Profile? profile, bool isNewToDB = false)
        {
            if (profile == null)
                return;

            if(!isNewToDB)
                nameContainer.ReleaseNames(profile.ID);

            var desiredID = $"{profile.Type}_{profile.Manufacturer}_{profile.Name}";

            profile.ID = nameContainer.TakeNextValid(desiredID);
        }

        private void SubtractFromManufacturer(string manufacturer)
        {
            var newCount = --fileCountByManufacturer[manufacturer];

            if (newCount == 0)
                fileCountByManufacturer.Remove(manufacturer);
        }

        private void AddToManufacturer(string manufacturer)
        {
            if (!fileCountByManufacturer.ContainsKey(manufacturer))
                fileCountByManufacturer[manufacturer] = 0;

            fileCountByManufacturer[manufacturer]++;
        }

        internal void UnloadProfile()
        {
            CurrentProfile = null;
            CurrentSubProfileIndex = -1;
        }
    }
}