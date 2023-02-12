using System;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class ProfileManager
    {
        public Profile CurrentProfile { get; private set; }

        internal Profile CreateNewProfile()
        {
            throw new NotImplementedException();
        }

        internal void UpdateCurrentProfileType(ProfileType type)
        {
            throw new NotImplementedException();
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