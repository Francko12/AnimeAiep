using AnimeAiep.DTO;
using AnimeAiep.Negocios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimeAiep.Pages
{
    public class CategoriasModel : PageModel
    {
        private readonly ICategoriaNegocio _categoriaNegocio;

        public CategoriasModel(ICategoriaNegocio categoriaNegocio)
        {
            _categoriaNegocio = categoriaNegocio;
        }
        public List<CategoriaDTO> Categorias { get; set; }
        public void OnGet()
        {
            Categorias = _categoriaNegocio.ObtenerCategorias();
        }
    }
}
