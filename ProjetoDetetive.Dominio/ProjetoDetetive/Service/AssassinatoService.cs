using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Service
{
    public class AssassinatoService : IAssassinatoService
    {
        private readonly ILocalRepository _localRepository;
        private readonly IArmaRepository _armaRepository;
        private readonly ISuspeitoRepository _suspeitoRepository;

        public AssassinatoService
        (
            ILocalRepository localRepository,
            IArmaRepository armaRepository,
            ISuspeitoRepository uspeitoRepository
        )
        {
            _localRepository = localRepository;
            _armaRepository = armaRepository;
            _suspeitoRepository = uspeitoRepository;

        }

        public SuspeitoEntity Assassino()
        {
            var lstSuspeitos = _suspeitoRepository.Listar();
            int totalSuspeitos = lstSuspeitos.Count();
            Random random = new Random();
            var escolhido = random.Next(1, (totalSuspeitos));
            var assassino = lstSuspeitos.ElementAt(escolhido);
            return assassino;
        }

        public ArmaEntity Arma()
        {
            var lstArmas = _armaRepository.Listar();
            int totalArmas = lstArmas.Count();
            Random random = new Random();
            var escolhido = random.Next(1, (totalArmas));
            var armaAssassinato = lstArmas.ElementAt(escolhido);
            return armaAssassinato;
        }

        public LocalEntity Local()
        {
            var lstLocais = _localRepository.Listar();
            int totalLocais = lstLocais.Count();
            Random random = new Random();
            var escolhido = random.Next(1, (totalLocais));
            var localAssassinato = lstLocais.ElementAt(escolhido);
            return localAssassinato;
        }
    }
}
