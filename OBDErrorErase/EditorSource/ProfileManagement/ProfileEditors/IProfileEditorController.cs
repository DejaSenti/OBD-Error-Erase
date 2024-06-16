using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{
    public interface IProfileEditorController
    {
        event Action? AddressChangedEvent;
        void SetGUI(IProfileEditorGUI profileEditorGUI);
        void Dispose();
        void FillSubprofileData(SubprofileData? data);
    }
}