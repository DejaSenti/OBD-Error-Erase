using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public static class ProfileEditorGUIFactory
    {
        public static IProfileEditorGUI GetEditorGUI(ProfileType type)
        {
            return type switch
            {
                ProfileType.BOSCH => new BoschProfileEditorGUI(),
                ProfileType.DELPHI => new DelphiProfileEditorGUI(),
                _ => throw new Exception($"Profile type {type} was not recognized!")
            };
        }
    }
}