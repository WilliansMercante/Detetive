using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Infra.Context;
using ProjetoDetetive.Infra.Repository.RepositoryBase;

namespace ProjetoDetetive.Infra.Repository.ProjetoDetetive
{
    public sealed class AssassinatoRepository : RepositoryBase<AssassinatoEntity, ProjetoDetetiveContext>, IAssassinatoRepository
    {
        public AssassinatoRepository(ProjetoDetetiveContext context) : base(context)
        {
        }

        public AssassinatoEntity ObterUltimo()
        {
            var oAssassinatoEntity = _context.Assassinato.OrderByDescending(p => p.DtCadastro).First();
            return oAssassinatoEntity;
        }

        public override void Incluir(AssassinatoEntity obj)
        {
            base.Incluir(obj);
            _context.SaveChanges();
        }
    }
}
