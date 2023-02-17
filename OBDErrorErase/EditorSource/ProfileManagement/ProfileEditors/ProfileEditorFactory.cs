using OBDErrorErase.EditorSource.AppControl;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public static class ProfileEditorFactory
    {
        public static IProfileEditorController GetEditorController(ProfileType type)
        {
            return type switch
            {
                ProfileType.BOSCH => new BoschProfileEditor(),
                ProfileType.DELPHI => new DelphiProfileEditor(),
                _ => throw new Exception($"Profile type {type} was not recognized!")
            };
        }
    }
}