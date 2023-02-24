using Microsoft.EntityFrameworkCore;

using ProjetoDetetive.Dominio.EntidadeBase;

namespace ProjetoDetetive.Infra.Repository.RepositoryBase
{
    public class RepositoryBase<TEntity, TContext>
    where TEntity : Entidade
    where TContext : DbContext
    {
        protected readonly TContext _context;

        public RepositoryBase(TContext context)
        {
            _context = context;
        }

        public virtual void Atualizar(List<TEntity> list)
        {
            _context.Entry(list).State = EntityState.Modified;
        }

        public virtual void Atualizar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual TEntity ConsultarPorId(int id)
        {
            var query = _context.Set<TEntity>().Where(p => p.Id.Equals(id));
            return query.Any() ? query.First() : null;
        }

        public virtual void Incluir(List<TEntity> list)
        {
            _context.Set<TEntity>().AddRange(list);
        }

        public virtual void Incluir(TEntity obj)
        {
            var dtCadastro = obj.GetType().GetProperty("DtCadastro");
            if (dtCadastro != null)
            {
                dtCadastro.SetValue(obj, DateTime.Now);
            }
            _context.Set<TEntity>().Add(obj);            
        }

        public virtual IEnumerable<TEntity> Listar()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public virtual void Excluir(int id)
        {
            var obj = ConsultarPorId(id);
            _context.Remove(obj);
        }
    }


}
