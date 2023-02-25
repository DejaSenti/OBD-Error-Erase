using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap : IDirty
    {
        const int SEARCH_WORD_LENGTH = 50;
		
        protected bool isDirty;
        [JsonIgnore]
        public virtual bool IsDirty => isDirty || searchWord.IsDirty;

        private DirtyList<byte> searchWord = new();
        public DirtyList<byte> SearchWord { get => searchWord; set { searchWord = value; isDirty = true; } }

        private string name = "";
        public string Name { get => name; set { name = value; isDirty = true; } }

        public BaseProfileMap()
        {
        }

        public BaseProfileMap(string name)
        {
            Name = name;
        }

        public void SetSearchWord(int location, BinaryFile file)
        {
            if (file != null)
            {
                SearchWord = new DirtyList<byte>(file.ReadValue(location, SEARCH_WORD_LENGTH));
            }
		}
		
        public virtual void ClearDirty(bool deep = true)
        {
            isDirty = false;

            if (!deep) 
                return;

            searchWord.ClearDirty();
        }
    }
}