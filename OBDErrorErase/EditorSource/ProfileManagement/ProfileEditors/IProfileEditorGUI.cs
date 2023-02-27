namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public interface IProfileEditorGUI
    {
        public UserControl UserControl { get; }
        void Dispose();
    }
}