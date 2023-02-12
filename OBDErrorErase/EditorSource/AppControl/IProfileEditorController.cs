using OBDErrorErase.EditorSource.GUI;

namespace OBDErrorErase.EditorSource.AppControl
{
    public interface IProfileEditorController
    {
        void SetGUI(IProfileEditorGUI profileEditorGUI);
        void RemoveListeners();
    }
}