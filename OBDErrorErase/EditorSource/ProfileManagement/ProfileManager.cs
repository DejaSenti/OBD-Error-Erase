using System;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile CurrentProfile { get; private set; }

        internal Profile CreateNewProfile()
        {
            var profile = new Profile();
            profile.Manufacturer = "None";
            profile.Name = "NewProfile";
            profile.Type = ProfileType.BOSCH;

            PopulateDefaultValues(profile);

            CurrentProfile = profile;

            return CurrentProfile;
        }

        internal void UpdateCurrentProfileType(ProfileType type)
        {
            CurrentProfile.Type = type;
            PopulateDefaultValues(CurrentProfile);
        }

        private void PopulateDefaultValues(Profile profile)
        {
            profile.Subprofiles = new();
            
            switch(profile.Type)
            {
                case ProfileType.BOSCH:
                    break;
                case ProfileType.DELPHI:
                    break;
            }
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