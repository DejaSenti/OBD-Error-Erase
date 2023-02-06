namespace UITest
{
    public interface IProfileEditorController
    {
        void SetGUI(IProfileEditorGUI profileEditorGUI);
        void RemoveListeners();
    }
}