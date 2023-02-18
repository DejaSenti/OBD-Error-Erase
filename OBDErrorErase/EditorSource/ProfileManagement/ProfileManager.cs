using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.Utils;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile? CurrentProfile { get; private set; }

        private UniqueNameContainer nameContainer;

        private Dictionary<string, int> fileCountByManufacturer = new();
        private Dictionary<Profile, string> fileNameByProfile = new();

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

        public Profile CreateNewProfile(ProfileType type = ProfileType.BOSCH)
        {
            var profile = new Profile(type, ProfileManagerStrings.DEFAULT_MANUFACTURER_NAME, ProfileManagerStrings.DEFAULT_PROFILE_NAME);

            profile.PopulateDefaults();

            profile.ClearDirty(); //saftey against dirty new profiles

            profile.ID = GetValidProfileID(profile);

            AddToManufacturer(profile.Manufacturer);

            SaveProfile(profile, true);

            return profile;
        }

        public void SetCurrentProfile(Profile profile)
        {
            CurrentProfile = profile;
        }

        internal Profile? DuplicateCurrentProfile()
        {
            if (CurrentProfile == null)
                return null;

            var serialized = JsonSerializer.Serialize(CurrentProfile);
            var copy = JsonSerializer.Deserialize<Profile>(serialized);

            if (copy == null)
                return null;

            copy.ID = GetValidProfileID(copy);

            AddToManufacturer(copy.Manufacturer);

            SaveProfile(copy, true);

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

            var serialized = JsonSerializer.Serialize(profile);
            AppFileHelper.SaveStringFile(serialized, AppFolderNames.PROFILES, profile.ID);

            fileNameByProfile[profile] = profile.ID;

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

            SaveCurrentProfile();
        }

        public void SetCurrentProfileName(string newName)
        {
            if (CurrentProfile == null)
                return;

            AppFileHelper.RemoveFile(AppFolderNames.PROFILES, CurrentProfile.ID);

            CurrentProfile.Name = newName;

            UpdateProfileID(CurrentProfile);

            SaveCurrentProfile();
        }

        private void UpdateProfileID(Profile? profile)
        {
            if (profile == null)
                return;

            nameContainer.ReleaseNames(profile.ID);
            profile.ID = GetValidProfileID(profile);
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

        private string GetValidProfileID(Profile profile)
        {
            var desiredID = $"{profile.Type}_{profile.Manufacturer}_{profile.Name}";
            return nameContainer.TakeNextValid(desiredID);
        }
    }
}