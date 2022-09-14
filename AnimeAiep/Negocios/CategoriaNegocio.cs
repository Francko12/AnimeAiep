using AnimeAiep.Datos.Repositores;
using AnimeAiep.DTO;

namespace AnimeAiep.Negocios
{
    public class CategoriaNegocio : ICategoriaNegocio
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaNegocio(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public List<CategoriaDTO> ObtenerCategorias()
        {
            var listaCategoriasDTO = new List<CategoriaDTO>();
            var listaCategoriaEntidades = _categoriaRepositorio.obtenerTodas();
            foreach (var categoria in listaCategoriaEntidades)
            {
                var categoriaDTO = new CategoriaDTO { Id = categoria.Id, Nombre = categoria.Nombre };
                listaCategoriasDTO.Add(categoriaDTO);
            }


            return listaCategoriasDTO;

        }
    }
}
