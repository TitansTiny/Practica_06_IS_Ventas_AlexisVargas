using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiRest.Controllers
{
    public class CategoriasNegocioController : ApiController
    {
        CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        // GET: CategoriasNegocio
        public IHttpActionResult Get()
        {
            var respuesta = categoriasNegocio.ListadoClientesCategoria();
            return Ok(respuesta);
        }
    }
}