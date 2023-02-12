namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class Profile
    {
        public ProfileType Type;

        public string manufacturer;
        public string name;

        private List<SubprofileData> subprofiles = new();
    }
}