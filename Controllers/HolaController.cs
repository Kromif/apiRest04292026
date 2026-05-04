using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiRest04292026.Controllers
{
    public class HolaController : ApiController
    {
        [HttpGet]
        [Route("api/hola/{nombre}")]
        public string SaludarPorRuta(string nombre)
        {
            return $"Hola, {nombre}";
        }
    }
}