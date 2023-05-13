using OBDErrorErase.EditorSource.Processors;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public static class ErrorProcessorFactory
    {
        public static BaseErrorProcessor Create(ProfileType type)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return type switch
            {
                ProfileType.BOSCH => new BoschErrorProcessor(),
                ProfileType.DELPHI => new DelphiErrorProcessor(),
                _ => null
            };
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}