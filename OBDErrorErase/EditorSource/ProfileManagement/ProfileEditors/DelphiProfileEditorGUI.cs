using OBDErrorErase.EditorSource.GUI;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public class DelphiProfileEditorGUI : IProfileEditorGUI
    {
        private EditorDelphi control;

        public UserControl UserControl => control;

        public DelphiProfileEditorGUI()
        {
            control = new EditorDelphi();
        }

        public void SetGUI(EditorGUI editorGUI)
        {
        }

        public void Dispose()
        {
            control.Dispose();
        }
    }
}