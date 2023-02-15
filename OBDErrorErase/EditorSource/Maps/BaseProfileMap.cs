using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap : IDirty
    {
        protected bool isDirty;
        public virtual bool IsDirty => isDirty || searchWords.IsDirty;

        private string name;
        public string Name { get => name; set { name = value; isDirty = true; } }

        private DirtyList<string> searchWords = new();
        public DirtyList<string> SearchWords => searchWords;

        public virtual void ClearDirty(bool deep = true)
        {
            isDirty = false;

            if (!deep) 
                return;

            searchWords.ClearDirty();
        }
    }
}