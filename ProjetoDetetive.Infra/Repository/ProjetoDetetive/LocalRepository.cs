using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Infra.Context;
using ProjetoDetetive.Infra.Repository.RepositoryBase;

namespace ProjetoDetetive.Infra.Repository.ProjetoDetetive
{
    public sealed class LocalRepository : RepositoryBase<LocalEntity, ProjetoDetetiveContext>, ILocalRepository
    {
        public LocalRepository(ProjetoDetetiveContext context) : base(context)
        {
        }
    }
}
