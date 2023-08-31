using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursDLC
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> listServives = new Dictionary<Type, object>();

        public static void RegisterService<T>(T service)
        {
            listServives[typeof(T)] = service;
        }

        public static T GetService<T>()
        {
            return (T)listServives[typeof(T)];
        }

    }
}
