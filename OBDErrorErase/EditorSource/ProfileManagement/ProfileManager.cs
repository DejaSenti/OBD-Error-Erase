using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.Utils;
using System.Text.Json;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile? CurrentProfile { get; private set; }

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

                fileCountByManufacturer.TryGetValue(profile.Manufacturer, out var currentCount); // returns 0 if doesn't exist

                fileCountByManufacturer[profile.Manufacturer] = currentCount + 1;
            }
        }

        public Profile CreateNewProfile(ProfileType type = ProfileType.BOSCH)
        {
            var profile = new Profile(type, ProfileManagerStrings.DEFAULT_MANUFACTURER_NAME, ProfileManagerStrings.DEFAULT_PROFILE_NAME);

            profile.PopulateDefaults();

            HandleProfileIDModified(profile, true);

            SaveProfile(profile, true);

            return profile;
        }

        public void SetCurrentProfile(Profile profile)
        {
            CurrentProfile = profile;
        }

        public void RemoveProfile(string id)
        {
            nameContainer.ReleaseNames(id);
            AppFileHelper.RemoveFile(AppFolderNames.PROFILES, id);
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

            if (profile.IsIDDirty)
            {
                RemoveProfile(profile.ID);
                HandleProfileIDModified(profile);
            }

            var serialized = JsonSerializer.Serialize(profile);
            AppFileHelper.SaveStringFile(serialized, AppFolderNames.PROFILES, profile.ID);

            profile.ClearDirty();
        }

        internal void SaveCurrentProfile()
        {
            if (CurrentProfile == null)
                throw new Exception("Can't save current profile because it is null.");

            SaveProfile(CurrentProfile);
        }

        private void HandleProfileIDModified(Profile profile, bool isNew = false)
        {
            if (!isNew)
            {
                if (fileCountByManufacturer.ContainsKey(profile.Manufacturer))
                {
                    var newCount = --fileCountByManufacturer[profile.Manufacturer];
                    if(newCount == 0)
                        fileCountByManufacturer.Remove(profile.Manufacturer);
                }
            }

            nameContainer.ReleaseNames(profile.ID);

            var desiredID = $"{profile.Type}_{profile.Manufacturer}_{profile.Name}";
            var validID = nameContainer.TakeNextValid(desiredID);

            profile.ID = validID;

            fileCountByManufacturer[profile.Manufacturer]++;
        }
    }
}