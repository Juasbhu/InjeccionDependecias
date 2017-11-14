using Developeros.Avanzado.Completo.Contratos;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace Developeros.Avanzado.Completo.Datos.Respositorios
{
    public abstract class RepositorioGenerico<TContext, TEntity> : IRepositorioGenerico<TEntity> where TContext : DbContext, new() where TEntity : class
    {
        //Esta propiedad es posible gracias a la restricciones de instaciacion que se crea en la firma de la clase.
        private TContext contexto = new TContext();

        protected RepositorioGenerico()
        {
            this.contexto.Configuration.ProxyCreationEnabled = false; 
        }

        public TContext Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        public virtual bool Agregar(TEntity entity)
        {
            //Podriamo agregar addrange, si se necesita en algun momento. si algo falla, lo vamos a manejar, aunque no es lo ideal, utilizamos try catthc con un bool

            try
            {
                this.contexto.Set<TEntity>().Add(entity);
                //throw new NotImplementedException();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Editar(TEntity entity)
        {
            try
            {
                //Cuando haga los cambio el sabra que esta pasando gracias al state
                this.contexto.Entry<TEntity>(entity).State = EntityState.Modified;
                //throw new NotImplementedException();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Eliminar(TEntity entity)
        {

            try
            {
                this.contexto.Set<TEntity>().Remove(entity);
                //throw new NotImplementedException();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual void Guardar()
        {
            this.contexto.SaveChanges();
            //throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> ObtenerPor(Expression<Func<TEntity, bool>> predicado)
        {
            //where, gracias a linq, como es lambda recibimos por paramentro y la pones el where directamente
            return this.contexto.Set<TEntity>().Where(predicado);
            //throw new NotImplementedException();
        }


        //El control de excepciones debe crear en otro lugar, MANEJO DE EXCEPCIONES A NIVEL GLOBAL
        public virtual IEnumerable<TEntity> ObtenerTodos()
        {
            return this.contexto.Set<TEntity>();
            //throw new NotImplementedException();
        }
    }
}
