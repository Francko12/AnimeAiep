using AnimeAiep.Datos.Entidades;
using AnimeAiep.Datos.Repositores;
using System.Data.SqlClient;
using System.Xml;

namespace AnimeAiep.Datos
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly IConfiguration _configuration;

        public CategoriaRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public list<Categoria> obtenerTodas()
        {
            var listaCategorias = new List<Categoria>();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("", sql);
            sql.Open(); 
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaCategoria = new Categoria { Id = (int)reader["Id"], Nombre = reader["Nombre"].ToString() };
                    listaCategorias.Add(nuevaCategoria);
                }
            }

            return listaCategorias;


        }
    }
}
