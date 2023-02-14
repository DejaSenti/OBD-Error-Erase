using System;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile? CurrentProfile { get; private set; }

        public Profile CreateNewProfile(ProfileType type = ProfileType.BOSCH, bool setAsCurrent = true)
        {
            var profile = new Profile(type, "None", "NewProfile");

            profile.PopulateDefaults();

            if (setAsCurrent)
                return CurrentProfile = profile;
            else
                return profile;
        }

        internal Profile LoadProfile(string id)
        {
            throw new NotImplementedException();
        }

        internal void SaveProfile()
        {
            throw new NotImplementedException();
        }

        public void SetCurrentProfile(Profile profile)
        {
            CurrentProfile = profile;
        }
    }


}