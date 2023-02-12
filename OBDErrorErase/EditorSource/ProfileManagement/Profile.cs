using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class Profile
    {
        public ProfileType Type { get; set; }

        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public List<SubprofileData> Subprofiles { get; set; } = new();

        public SubprofileData? GetMatchingSubprofile(BinaryFile file)
        {
            foreach (var subprofile in Subprofiles)
            {
                if (subprofile.TryFile(file))
                    return subprofile;
            }

            return null;
        }
    }
}