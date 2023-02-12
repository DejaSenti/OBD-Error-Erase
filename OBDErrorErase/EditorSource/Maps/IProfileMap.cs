using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    public interface IProfileMap
    {
        string SearchWord { get; }
        string Name { get; }

        void Process(BinaryFile file);
    }
}