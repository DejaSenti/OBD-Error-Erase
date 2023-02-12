using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    public abstract class BaseMap : IProfileMap
    {
        private string? name;
        private string? searchWord;

        public abstract void Process(BinaryFile file);
    }
}