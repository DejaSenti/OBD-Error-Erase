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
        const uint SEARCH_WORD_LENGTH = 50;
		
        protected bool isDirty;
        public virtual bool IsDirty => isDirty || searchWord.IsDirty;

        private DirtyList<byte> searchWord = new();
        public DirtyList<byte> SearchWord { get => searchWord; set { searchWord = value; isDirty = true; } }

        private string name;
        public string Name { get => name; set { name = value; isDirty = true; } }
		
        public uint Location; // needs to go, refactor accordingly

        public BaseProfileMap(string name, uint location)
        {
            Name = name;
            Location = location;
        }

        public void SetSearchWord(BinaryFile file)
        {
            if (file != null)
            {
                SearchWord = new DirtyList<byte>(file.ReadValue(Location, SEARCH_WORD_LENGTH));
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