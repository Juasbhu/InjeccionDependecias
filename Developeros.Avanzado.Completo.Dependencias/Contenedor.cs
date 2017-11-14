using Ninject;
using System.Reflection;

namespace Developeros.Avanzado.Completo.Dependencias
{
    public static class Contenedor
    {
        private static readonly StandardKernel Kernel;

        static Contenedor()
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T Resolver<T>()
        {
            return Kernel.Get<T>();
        }

    }
}
