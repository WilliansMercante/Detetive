using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Repository
{
    public interface ISuspeitoRepository
    {
        IEnumerable<SuspeitoEntity> Listar();
    }
}
