using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Processors;
using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class Profile : IDirty
    {
        public ProfileType Type { get; }

        private bool isDirty;
        public bool IsDirty => isDirty || Subprofiles.IsDirty || Subprofiles.Any(sp => sp.IsDirty);

        public string ID { get; set; }

        public bool IsIDDirty {get; private set; }

        private string manufacturer;
        public string Manufacturer { get => manufacturer; set { manufacturer = value; isDirty = IsIDDirty = true; } }

        private string name;
        public string Name { get => name; set { name = value; isDirty = IsIDDirty = true; } }

        public DirtyList<SubprofileData> Subprofiles { get; } = new();

        public SubprofileData CurrentSubprofile { get; private set; }

        private IErrorProcessor processor;

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

            CurrentSubprofile = Subprofiles[0];
        }

        public SubprofileData? GetMatchingSubprofile(BinaryFile file)
        {
            foreach (var subprofile in Subprofiles)
            {
                if (subprofile.IsSubprofileFit(file))
                    return subprofile;
            }

            return null;
        }

        public void SetSubprofile(SubprofileData subprofile)
        {
            CurrentSubprofile = subprofile;
        }

        internal int Process(BinaryFile currentFile, List<string> errorList)
        {
            if (CurrentSubprofile.FlipBytes)
            {
                FlipErrorBytes(errorList);
            }

            return processor.Process(currentFile, CurrentSubprofile, errorList);
        }

        private void FlipErrorBytes(List<string> errorList)
        {
            var result = new List<string>();

            foreach (var error in errorList)
            {
                var array = Convert.FromHexString(error);
                Array.Reverse(array);
                result.Add(new string(Convert.ToHexString(array)));
            }

            errorList.Clear();
            errorList.AddRange(result);
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