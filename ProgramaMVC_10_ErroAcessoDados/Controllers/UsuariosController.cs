using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ProgramaMVC_10_ErroAcessoDados.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly string _connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"; // String de conexão de exemplo

        public IActionResult Buscar(string nomeUsuario)
        {
            List<string> usuarios = new List<string>();
            string query = "SELECT Nome FROM Usuarios WHERE Nome = '" + nomeUsuario + "'"; // Bug: Vulnerável a SQL Injection

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(reader["Nome"].ToString());
                }
                reader.Close();
            }

            ViewBag.Usuarios = usuarios;
            return View();
        }
    }
}

