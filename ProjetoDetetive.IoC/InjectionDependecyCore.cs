using Microsoft.Extensions.DependencyInjection;

using ProjetoDetetive.Aplicacao.ProjetoDetetive;
using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface;
using ProjetoDetetive.Infra.Repository.ProjetoDetetive;

namespace ProjetoDetetive.IoC
{
    public static class InjectionDependencyCore
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            AddRepositories(services);
            AddApplication(services);
            AddServices(services);
        }

        private static void AddApplication(IServiceCollection services)
        {
            #region Detetive

            services.AddScoped<IArmaApp, ArmaApp>();
            services.AddScoped<ILocalApp, LocalApp>();
            services.AddScoped<ISuspeitoApp, SuspeitoApp>();
            services.AddScoped<IAssassinatoApp, AssassinatoApp>();

            #endregion
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAssassinatoService, AssassinatoService>();
            services.AddScoped<ITestemunhaService, TestemunhaService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            #region Configuracao

            services.AddScoped<IArmaRepository, ArmaRepository>();
            services.AddScoped<ILocalRepository, LocalRepository>();
            services.AddScoped<ISuspeitoRepository, SuspeitoRepository>();
            services.AddScoped<IAssassinatoRepository, AssassinatoRepository>();

            #endregion   
        }
    }
}
