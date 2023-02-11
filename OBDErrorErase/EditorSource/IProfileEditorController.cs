namespace OBDErrorErase
{
    public interface IProfileEditorController
    {
        void SetGUI(IProfileEditorGUI profileEditorGUI);
        void RemoveListeners();
    }
}