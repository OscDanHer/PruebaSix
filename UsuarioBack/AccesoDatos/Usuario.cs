using Dapper;
using Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
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
            var output = new GetUsuarioOut();
            output.listaUsuarios = new List<Entidades.Entities.Usuario>();


            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Query<Entidades.Entities.Usuario>(@"SELECT usuID, nombre, apellido FROM [Usuario]");
                if (result.Any())
                {
                    output.listaUsuarios = result.ToList();

                }
            }
            return output;
        }
    }
}
