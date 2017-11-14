using Developeres.Avanzado.Completo.Dominio;
using Developeros.Avanzado.Completo.Contratos;
using System.Collections.Generic;
using System.Web.Http;

namespace Developeros.Avanzado.Completo.Api.Controllers
{
    public class CategoriaController : ApiController
    {
        private readonly IGestionCategoria gestion;

        public CategoriaController(IGestionCategoria gestion)
        {
            this.gestion = gestion;
        }

        public CategoriaController()
        {

        }

        // GET api/<controller>
        public IEnumerable<Categoria> Get()
        {
            return this.gestion.ObtenerTodos();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]Categoria categoria)
        {
            this.gestion.Agregar(categoria);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Categoria categoria)
        {
            this.gestion.Editar(categoria);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}