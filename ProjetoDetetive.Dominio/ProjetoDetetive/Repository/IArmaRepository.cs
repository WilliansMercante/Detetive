using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Repository
{
    public interface IArmaRepository
    {
        IEnumerable<ArmaEntity> Listar();
    }
}
