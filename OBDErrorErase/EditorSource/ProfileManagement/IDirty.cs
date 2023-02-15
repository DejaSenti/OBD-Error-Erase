namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public interface IDirty
    {
        bool IsDirty { get; }
        void ClearDirty(bool deep = true);
    }
}