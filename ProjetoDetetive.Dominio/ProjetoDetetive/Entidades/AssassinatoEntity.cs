using ProjetoDetetive.Dominio.EntidadeBase;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Entidades
{
    public class AssassinatoEntity : Entidade
    {
        public int IdSuspeito { get; set; }
        public int IdArma { get; set; }
        public int IdLocal { get; set; }
        public DateTime DtCadastro { get; set; }

        public ArmaEntity Arma { get; set; }
        public LocalEntity Local { get; set; }
        public SuspeitoEntity Suspeito { get; set; }
    }
}
