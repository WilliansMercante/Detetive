namespace ProjetoDetetive.ViewModel.ProjetoDetetive
{
    public class AssassinatoViewModel
    {
        public int IdSuspeito { get; set; }
        public int IdArma { get; set; }
        public int IdLocal { get; set; }
        public DateTime DtCadastro { get; }

        public ArmaViewModel Arma { get; set; }
        public LocalViewModel Local { get; set; }
        public SuspeitoViewModel Suspeito { get; set; }
    }
}
