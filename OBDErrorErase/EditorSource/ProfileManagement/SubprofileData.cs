﻿using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class SubprofileData : IDirty
    {
        protected bool isDirty;
        [JsonIgnore]
        public bool IsDirty => isDirty || Maps.IsDirty || Maps.Any(map => map.IsDirty);

        private int mapLength;
        public int MapLength { get => mapLength; set { mapLength = value; isDirty = true; } }

        private bool flipBytes;
        public bool FlipBytes { get => flipBytes; set { flipBytes = value; isDirty = true; } }

        public DirtyList<BaseProfileMap> Maps { get; set; } = new();

        public bool FitsBinaryFile(BinaryFile file)
        {
            foreach (var map in Maps)
            {
                int mapLocation = file.FindValue(map.SearchWord.ToArray(), 0, file.Length);

                if (mapLocation == -1)
                    return false;
            }

            return true;
        }

        public void ClearDirty(bool deep = true)
        {
            isDirty = false;
            if (!deep)
                return;

            Maps.ClearDirty();
            foreach (var map in Maps)
                map.ClearDirty();
        }

        public List<string> GetMapNameList()
        {
            var result = new List<string>();

            foreach (var map in Maps)
            {
                result.Add(map.Name);
            }

            return result;
        }

        internal void FillMapPositions(BinaryFile file)
        {
            foreach (var map in Maps)
            {
                int mapLocation = file.FindValue(map.SearchWord.ToArray(), 0, file.Length); // this should always be successful

                map.SetLocation(mapLocation);
            }
        }

        internal int GetMapLocation(string name)
        {
            foreach (var map in Maps)
            {
                if (map.Name.ToLower() == name.ToLower())
                {
                    return map.Location;
                }
            }

            return -1;
        }
    }
}