using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Processors;
using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class Profile : IDirty
    {
        private bool isDirty;
        public bool IsDirty => isDirty || Subprofiles.IsDirty || Subprofiles.Any(sp => sp.IsDirty);

        public bool IsIDDirty {get; private set; }

        public string ID { get; set; }

        public ProfileType Type { get; }

        private string manufacturer;
        public string Manufacturer { get => manufacturer; set { manufacturer = value; isDirty = IsIDDirty = true; } }

        private string name;
        public string Name { get => name; set { name = value; isDirty = IsIDDirty = true; } }

        public DirtyList<SubprofileData> Subprofiles { get; } = new();

        private BaseErrorProcessor processor;

        public Profile(ProfileType type, string manufacturer, string name)
        {
            Type = type;

            this.manufacturer = manufacturer;
            this.name = name;

            processor = ErrorProcessorFactory.Create(type);
        }

        internal void PopulateDefaults()
        {
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

        public void ClearDirty(bool deep = true)
        {
            isDirty = false;
            if (!deep)
                return;
            Subprofiles.ClearDirty();
            foreach (var subProfile in Subprofiles)
                subProfile.ClearDirty();
        }
    }
}