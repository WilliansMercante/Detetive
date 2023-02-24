using Microsoft.AspNetCore.Mvc.Rendering;

using ProjetoDetetive.ViewModel.ProjetoDetetive;

namespace ProjetoDetetive.Ui.Web.Models
{
    public class IndexViewModel
    {
        public LocalViewModel Local { get; set; }
        public ArmaViewModel Arma { get; set; }
        public SuspeitoViewModel Suspeito { get; set; }

        public SelectList Suspeitos { get; set; } = new SelectList(new List<string>());
        public SelectList Locais { get; set; } = new SelectList(new List<string>());
        public SelectList Armas { get; set; } = new SelectList(new List<string>());
    }
}
