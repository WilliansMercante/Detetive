using AutoMapper;

using ProjetoDetetive.Aplicacao.Mapping;
using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.ProjetoDetetive
{
    public class SuspeitoApp : ISuspeitoApp
    {

        private readonly ISuspeitoRepository _SuspeitoRepository;
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();

        public SuspeitoApp
        (
            ISuspeitoRepository suspeitoRepository
        )
        {
            _SuspeitoRepository = suspeitoRepository;
        }

        public IEnumerable<SuspeitoViewModel> Listar()
        {
            var lstSuspeitoDM = _SuspeitoRepository.Listar();
            return _mapper.Map<IEnumerable<SuspeitoEntity>, IEnumerable<SuspeitoViewModel>>(lstSuspeitoDM);
        }
    }
}
