using System;
using System.Collections.Generic;
using Developeres.Avanzado.Completo.Dominio;
using Developeros.Avanzado.Completo.Contratos;
using Developeros.Avanzado.Completo.Dependencias;

namespace Developeros.Avanzado.Completo.Negocio
{
    public class GestionCategoria : GestionBasse<IRepositorioCategoria, Categoria>, IGestionCategoria
    {  
        public override IEnumerable<Categoria> ObtenerPor()
        {
            throw new NotImplementedException();
        }
    }
}
