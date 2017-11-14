using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Developeros.Avanzado.Completo.Contratos
{
    public interface IRepositorioGenerico<TEntity>
    {
        IEnumerable<TEntity> ObtenerTodos();

        IEnumerable<TEntity> ObtenerPor(Expression<Func<TEntity, bool>> predicado);

        bool Agregar(TEntity entity);

        bool Editar(TEntity entity);

        bool Eliminar(TEntity entity);

        void Guardar();
    }
}
