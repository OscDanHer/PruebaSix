using Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Usuario
    {
        private string connectionString;

        public Usuario(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public GetUsuarioOut GetUsuario()
        {
            var dataAcess = new AccesoDatos.Usuario(this.connectionString);
            return dataAcess.GetUsuario();
        }
    }
}
