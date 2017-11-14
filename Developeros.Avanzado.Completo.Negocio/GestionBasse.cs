using Developeros.Avanzado.Completo.Contratos;
using Developeros.Avanzado.Completo.Dependencias;
using System.Collections.Generic;

namespace Developeros.Avanzado.Completo.Negocio
{
    public abstract class GestionBasse<TRepositorio, TEntity> : IGestionBasse<TEntity>
        where TRepositorio : IRepositorioGenerico<TEntity>
    {
        private TRepositorio repositorio;

        protected GestionBasse(TRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        protected GestionBasse() 
            : this(Contenedor.Resolver<TRepositorio>())
        {
        }

        public virtual IEnumerable<TEntity> ObtenerTodos()
        {
            return this.repositorio.ObtenerTodos();
        }

        public abstract IEnumerable<TEntity> ObtenerPor();

        public virtual bool Agregar(TEntity entity)
        {
            return this.repositorio.Agregar(entity);
        }

        public virtual bool Editar(TEntity entity)
        {
            return this.repositorio.Editar(entity);
        }

        public virtual bool Eliminar(TEntity entity)
        {
            return this.repositorio.Eliminar(entity);
        }

        public virtual void Guardar()
        {
            this.repositorio.Guardar(); 
        }


    }
}
