using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{
    public interface IProfileEditorController
    {
        void SetGUI(IProfileEditorGUI profileEditorGUI, Profile profile);
        void Dispose();
    }
}