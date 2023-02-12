namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class Profile
    {
        public ProfileType Type { get; private set; }

        private string? manufacturer;
        private string? name;
        private bool flipBytes;

        private List<SubprofileData> subprofiles = new();
    }
}