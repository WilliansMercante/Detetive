using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface
{
    public interface IAssassinatoService
    {
        SuspeitoEntity Assassino();
        ArmaEntity Arma();
        LocalEntity Local();
    }
}
