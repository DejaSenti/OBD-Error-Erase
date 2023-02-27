using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.Processors;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class Profile : IDirty
    {
        public ProfileType Type { get; }

        private bool isDirty;
        [JsonIgnore]
        public bool IsDirty => isDirty || Subprofiles.IsDirty || Subprofiles.Any(sp => sp.IsDirty);

        public string ID { get; set; }

        private string manufacturer;
        public string Manufacturer { get => manufacturer; set { manufacturer = value; isDirty = true; } }

        private string name;
        public string Name { get => name; set { name = value; isDirty = true; } }

        public DirtyList<SubprofileData> Subprofiles { get; set; } = new();

        private IErrorProcessor processor;

        public Profile(ProfileType type, string manufacturer, string name)
        {
            Type = type;

            this.manufacturer = manufacturer;
            this.name = name;

            processor = ErrorProcessorFactory.Create(type);
        }

        public void AddNewMap(BaseProfileMap newMap)
        {
            foreach (var subprofile in Subprofiles)
            {
                subprofile.Maps.Add(newMap);
            }
        }

        public void RemoveMap(int index)
        {

        }

        internal void PopulateDefaults()
        {
            processor.PopulateProfileDefaults(this);
        }

        public SubprofileData? GetMatchingSubprofile(BinaryFile file)
        {
            foreach (var subprofile in Subprofiles)
            {
                if (subprofile.FitsBinaryFile(file))
                    return subprofile;
            }

            return null;
        }

        internal int Process(BinaryFile currentFile, List<string> errorList, int subprofileIndex, List<int> mapIndices)
        {
            var subProfile = Subprofiles[subprofileIndex];

            if (subProfile.FlipBytes)
            {
                FlipErrorBytes(errorList);
            }

            return processor.Process(currentFile, subProfile, errorList, mapIndices);
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