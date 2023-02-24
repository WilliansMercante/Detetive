using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Infra.Context;
using ProjetoDetetive.Infra.Repository.RepositoryBase;

namespace ProjetoDetetive.Infra.Repository.ProjetoDetetive
{
    public sealed class SuspeitoRepository : RepositoryBase<SuspeitoEntity, ProjetoDetetiveContext>, ISuspeitoRepository
    {
        public SuspeitoRepository(ProjetoDetetiveContext context) : base(context)
        {
        }
    }
}
