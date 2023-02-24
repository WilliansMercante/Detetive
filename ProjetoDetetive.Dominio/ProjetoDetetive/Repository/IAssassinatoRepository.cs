using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Repository
{
    public interface IAssassinatoRepository
    {
        public AssassinatoEntity ObterUltimo();
        void Incluir(AssassinatoEntity assassinatoDM);
    }
}
