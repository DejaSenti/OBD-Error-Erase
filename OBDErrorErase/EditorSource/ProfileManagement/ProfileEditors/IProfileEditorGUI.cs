using OBDErrorErase.EditorSource.GUI;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public interface IProfileEditorGUI
    {
        public UserControl UserControl { get; }
        void SetGUI(EditorGUI editorGUI);
        void Dispose();
    }
}