using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Repository
{
    public interface ILocalRepository
    {
        IEnumerable<LocalEntity> Listar();
    }
}
