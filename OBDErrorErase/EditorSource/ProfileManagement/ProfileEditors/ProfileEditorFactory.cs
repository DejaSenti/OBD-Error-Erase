using OBDErrorErase.EditorSource.AppControl;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public static class ProfileEditorFactory
    {
        public static IProfileEditorController GetEditorController(ProfileType type)
        {
            return type switch
            {
                ProfileType.BOSCH => new BoschProfileEditorController(),
                ProfileType.DELPHI => new DelphiProfileEditorController(),
                _ => throw new Exception($"Profile type {type} was not recognized!")
            };
        }
    }
}