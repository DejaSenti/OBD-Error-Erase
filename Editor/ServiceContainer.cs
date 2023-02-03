using System;
using System.Collections.Generic;

namespace UITest
{
    public static class ServiceContainer
    {
        private static Dictionary<Type, object> servicesByType;

        public static void AddService<T>(T service)
        {
            servicesByType[typeof(T)] = service;
        }

        public static T GetService<T>()
        {
            return (T)servicesByType[typeof(T)];
        }
    }
}