using OBDErrorErase.EditorSource.GUI;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public class BoschProfileEditorGUI : IProfileEditorGUI
    {
        private EditorBosch control;

        public UserControl UserControl => control;

        public BoschProfileEditorGUI()
        {
            control = new EditorBosch();
        }

        public void SetGUI(EditorGUI editorGUI)
        {
            // populate the map editor frames with the current profile's maps
            // listen to buttons and field changes, notify controller
        }

        public void Dispose()
        {
            // stop listening to buttons and field changes

            // dispose of EditorBosch control
            control.Dispose();
        }
    }
}