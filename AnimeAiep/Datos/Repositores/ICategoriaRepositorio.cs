using AnimeAiep.Datos.Entidades;

namespace AnimeAiep.Datos.Repositores
{
    public interface ICategoriaRepositorio
    {
        list<Categoria> obtenerTodas();
    }
}
