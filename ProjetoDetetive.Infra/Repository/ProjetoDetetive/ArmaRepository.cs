using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Infra.Context;
using ProjetoDetetive.Infra.Repository.RepositoryBase;

namespace ProjetoDetetive.Infra.Repository.ProjetoDetetive
{
    public sealed class ArmaRepository : RepositoryBase<ArmaEntity, ProjetoDetetiveContext>, IArmaRepository
    {
        public ArmaRepository(ProjetoDetetiveContext context) : base(context)
        {
        }
    }
}
