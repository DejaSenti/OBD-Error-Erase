using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Utils;
using System.Text.Json;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile? CurrentProfile { get; private set; }

        private UniqueNameContainer nameContainer;

        public ProfileManager()
        {
            var existingProfileIDs = AppFileHelper.GetAllFilesInAppSubFolder(AppFolderNames.PROFILES)
                .Select(fileInfo => Path.GetFileNameWithoutExtension(fileInfo.Name))
                .ToArray();

            nameContainer = new UniqueNameContainer(string.Empty);
            nameContainer.TakeNames(existingProfileIDs);
        }

        public Profile CreateNewProfile(ProfileType type = ProfileType.BOSCH, bool setAsCurrent = true)
        {
            var profile = new Profile(type, ProfileManagerStrings.DEFAULT_MANUFACTURER_NAME, ProfileManagerStrings.DEFAULT_PROFILE_NAME);

            profile.PopulateDefaults();

            HandleProfileIDModified(profile);

            SaveProfile(profile, true);

            if (setAsCurrent)
                CurrentProfile = profile;

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

        public Profile? LoadProfile(string id)
        {
            var profileContents = AppFileHelper.LoadStringFile(AppFolderNames.PROFILES, id);
            var result = JsonSerializer.Deserialize<Profile>(profileContents);
            return result;
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

        private void HandleProfileIDModified(Profile profile)
        {
            nameContainer.ReleaseNames(profile.ID);

            var desiredID = $"{profile.Type}_{profile.Manufacturer}_{profile.Name}";
            var validID = nameContainer.TakeNextValid(desiredID);

            profile.ID = validID;
        }
    }
}