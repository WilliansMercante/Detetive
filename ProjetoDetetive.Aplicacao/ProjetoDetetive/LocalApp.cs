using AutoMapper;

using ProjetoDetetive.Aplicacao.Mapping;
using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.ProjetoDetetive
{
    public class LocalApp : ILocalApp
    {
        private readonly ILocalRepository _localRepository;
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();

        public LocalApp
        (
            ILocalRepository localRepository
        )
        {
            _localRepository = localRepository;
        }

        public IEnumerable<LocalViewModel> Listar()
        {
            var lstLocalDM = _localRepository.Listar();
            return _mapper.Map<IEnumerable<LocalEntity>, IEnumerable<LocalViewModel>>(lstLocalDM);
        }
    }
}
