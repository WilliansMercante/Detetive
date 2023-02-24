using AutoMapper;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Aplicacao.Mapping
{
    public class MapperConfig
    {
        public static IMapper RegisterMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                ProjetoDetetive(cfg);
            });

            return config.CreateMapper();
        }

        private static void ProjetoDetetive(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ArmaEntity, ArmaViewModel>();
            cfg.CreateMap<SuspeitoEntity, SuspeitoViewModel>();
            cfg.CreateMap<AssassinatoEntity, AssassinatoViewModel>();
            cfg.CreateMap<LocalEntity, LocalViewModel>();
        }
    }
}
