using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Processors;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class Profile
    {
        public ProfileType Type { get; set; }

        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public List<SubprofileData> Subprofiles { get; set; } = new();

        private BaseErrorProcessor processor;

        public Profile(ProfileType type, string manufacturer, string name) 
        {
            Type = type;
            Manufacturer = manufacturer;
            Name = name;
            processor = ErrorProcessorFactory.Create(type);

            processor.PopulateProfileDefaults(this);
        }

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