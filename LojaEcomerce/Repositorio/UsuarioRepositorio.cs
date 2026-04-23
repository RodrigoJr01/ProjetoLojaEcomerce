using LojaEcomerce.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace LojaEcomerce.Repositorio
{
    public class UsuarioRepositorio
    {
        //variavel privada e somenete para leitura
        private readonly string _connectionString;

        public UsuarioRepositorio(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Conexão");
        }
        //metodo para validar o login 


        public LoginViewModel Validar(string email, string senha)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            var sql = "SELECT * FROM tb_Usuario WHERE Email= @email AND Senha = @senha";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new LoginViewModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    Nivel = reader["Nivel"].ToString()
                };
            }
            return null;

        }
    }
}