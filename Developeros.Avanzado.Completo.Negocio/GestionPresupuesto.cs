using Developeros.Avanzado.Completo.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developeres.Avanzado.Completo.Dominio;

namespace Developeros.Avanzado.Completo.Negocio
{
    public class GestionPresupuesto : GestionBasse<IRepositorioPresupuesto, Presupuesto>, IGestionPresupuesto
    {
        public override IEnumerable<Presupuesto> ObtenerPor()
        {
            throw new NotImplementedException();
        }
    }
}
