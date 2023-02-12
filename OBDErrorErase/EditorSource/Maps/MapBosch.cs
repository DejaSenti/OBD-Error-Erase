using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{

    public class MapBosch : IProfileMap
    {
        private string? newValue;
        private int width;

        public MapBosch(string? newValue, int width)
        {
            this.newValue = newValue;
            this.width = width;
        }

        public void Process(BinaryFile file)
        {
            throw new NotImplementedException();
        }
    }
}