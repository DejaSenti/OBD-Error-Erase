namespace OBDErrorErase.EditorSource.AppControl
{
    public static class ServiceContainer
    {
        private static Dictionary<Type, object> servicesByType = new();

        public static void AddService<T>(T service)
        {
            if (service == null)
                throw new NullReferenceException();

            servicesByType[typeof(T)] = service;
        }

        public static T GetService<T>()
        {
            return (T)servicesByType[typeof(T)];
        }
    }
}