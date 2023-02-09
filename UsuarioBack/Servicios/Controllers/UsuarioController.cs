using Entidades.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http.Results;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        public IConfiguration configuration;
        public UsuarioController(IConfiguration iconfig)
        {
            configuration = iconfig;
        }

        [HttpGet]
        [Route("GetUsuario")]
        public List<Entidades.Entities.Usuario> GetUsuario()
        {
            var negocio = new Negocios.Usuario(configuration.GetValue<string>("Values:ConectionString"));
            var getUsuarioOut = negocio.GetUsuario();
            return getUsuarioOut.listaUsuarios;
        }
    }
}
