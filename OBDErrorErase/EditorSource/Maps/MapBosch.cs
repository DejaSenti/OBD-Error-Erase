﻿using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        public string NewValue { get; set; }
        public int Width { get; set; }

        public string SearchWord { get; set; }

        public string Name { get; set; }

        public MapBosch(string newValue, int width)
        {
            NewValue = newValue;
            Width = width;
        }

        public void Process(BinaryFile file, string error)
        {
            throw new NotImplementedException();
        }
    }
}