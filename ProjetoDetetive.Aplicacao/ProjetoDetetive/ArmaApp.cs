using AutoMapper;

using ProjetoDetetive.Aplicacao.Mapping;
using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.ProjetoDetetive
{
    public sealed class ArmaApp : IArmaApp
    {
        private readonly IArmaRepository _armaRepository;
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();

        public ArmaApp
        (
            IArmaRepository armaRepository
        )
        {
            _armaRepository = armaRepository;
        }

        public IEnumerable<ArmaViewModel> Listar()
        {
            var lstArmaDM = _armaRepository.Listar();
            return _mapper.Map<IEnumerable<ArmaEntity>, IEnumerable<ArmaViewModel>>(lstArmaDM);
        }
    }
}
