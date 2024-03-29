﻿using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap : IDirty
    {
        public const int ERROR_VALUE_LEN = 2;
        protected const int PREVIEW_LENGTH = 100;
        private const int SEARCH_WORD_LENGTH = 50;

        protected bool isDirty;
        [JsonIgnore]
        public virtual bool IsDirty => isDirty || searchWord.IsDirty || newValue.IsDirty;

        private DirtyList<byte> newValue = new();
        public DirtyList<byte> NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        private DirtyList<byte> searchWord = new();
        public DirtyList<byte> SearchWord { get => searchWord; set { searchWord = value; isDirty = true; } }

        private string name = "";
        public string Name { get => name; set { name = value; isDirty = true; } }

        [JsonIgnore]
        public int Location { get; private set; }

        public BaseProfileMap()
        {
        }

        public BaseProfileMap(string name)
        {
            Name = name;
            Location = -1;
        }

        public void SetLocation(int location)
        {
            Location = location;
        }

        public DirtyList<byte> CreateSearchWord(int location, BinaryFile file)
        {
            return new DirtyList<byte>(file.ReadValue(location, SEARCH_WORD_LENGTH));
        }

        public void SetSearchWord(int location, BinaryFile file)
        {
            if (file != null)
            {
                SearchWord = CreateSearchWord(location, file);
            }
		}

        public void SetSearchWord(DirtyList<byte> searchWord)
        {
            SearchWord = searchWord;
		}
		
        public virtual void ClearDirty(bool deep = true)
        {
            isDirty = false;

            if (!deep) 
                return;

            searchWord.ClearDirty();
        }

        public abstract byte[][] GetErrorList(BinaryFile file, int displayLocation);
    }
}