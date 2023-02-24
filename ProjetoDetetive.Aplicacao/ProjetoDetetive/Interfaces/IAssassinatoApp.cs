using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces
{
    public interface IAssassinatoApp
    {
        public AssassinatoViewModel ObterUltimo();
        void Incluir();
    }
}
