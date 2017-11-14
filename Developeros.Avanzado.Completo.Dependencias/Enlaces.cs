using System;
using Ninject.Modules;
using Developeros.Avanzado.Completo.Contratos;
using Developeros.Avanzado.Completo.Datos.Respositorios;

namespace Developeros.Avanzado.Completo.Dependencias
{
    public class Enlaces : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepositorioCategoria>().To<RepositorioCategoria>();
            this.Bind<IRepositorioPresupuesto>().To<RepositorioPresupuesto>();
        }
    }
}
