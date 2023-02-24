using AutoMapper;

using ProjetoDetetive.Aplicacao.Mapping;
using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface;
using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.ProjetoDetetive
{
    public class AssassinatoApp : IAssassinatoApp
    {
        private readonly IAssassinatoRepository _assassinatoRepository;
        private readonly IAssassinatoService _assassinatoService;
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();

        public AssassinatoApp
        (
            IAssassinatoRepository assassinatoRepository,
            IAssassinatoService assassinatoService
        )
        {
            _assassinatoRepository = assassinatoRepository;
            _assassinatoService = assassinatoService;
        }



        public AssassinatoViewModel ObterUltimo()
        {
            var oAssassinatoEntity = _assassinatoRepository.ObterUltimo();
            return _mapper.Map<AssassinatoViewModel>(oAssassinatoEntity);
        }

        public void Incluir()
        {
            var oAssassinatoDM = new AssassinatoEntity()
            {
                Suspeito = _assassinatoService.Assassino(),
                Arma = _assassinatoService.Arma(),
                Local = _assassinatoService.Local(),
                
            };

            //oAssassinatoDM.DtCadastro = DateTime.Now;

            _assassinatoRepository.Incluir(oAssassinatoDM);
        }
    }
}
