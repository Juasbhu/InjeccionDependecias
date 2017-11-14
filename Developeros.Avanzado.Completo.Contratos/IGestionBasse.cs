using System.Collections.Generic;

namespace Developeros.Avanzado.Completo.Contratos
{
    public interface IGestionBasse<TEntity>
    {
        bool Agregar(TEntity entity);

        bool Editar(TEntity entity);

        bool Eliminar(TEntity entity);

        void Guardar();

        IEnumerable<TEntity> ObtenerPor();

        IEnumerable<TEntity> ObtenerTodos();
    }
}