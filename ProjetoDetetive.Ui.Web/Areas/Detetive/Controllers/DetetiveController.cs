using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using ProjetoDetetive.Aplicacao.ProjetoDetetive.Interfaces;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface;
using ProjetoDetetive.Ui.Web.Areas.Detetive.ViewModels;
using ProjetoDetetive.Ui.Web.Controllers;

namespace ProjetoDetetive.Ui.Web.Areas.Detetive.Controllers
{
    [Area("Detetive")]
    [Route("[controller]")]
    public class DetetiveController : BaseController
    {
        private readonly ILocalApp _localApp;
        private readonly IArmaApp _armaApp;
        private readonly ISuspeitoApp _suspeitoApp;
        private readonly IAssassinatoApp _assassinatoApp;
        private readonly ITestemunhaService _testemunhaService;

        public DetetiveController
        (
            ILocalApp localApp,
            IArmaApp armaApp,
            ISuspeitoApp suspeitoApp,
            IAssassinatoApp assassinatoApp,
            ITestemunhaService testemunhaService
        )
        {
            _localApp = localApp;
            _armaApp = armaApp;
            _suspeitoApp = suspeitoApp;
            _assassinatoApp = assassinatoApp;
            _testemunhaService = testemunhaService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            IndexViewModel indexVM = new IndexViewModel();

            try
            {
                _assassinatoApp.Incluir();

                indexVM.Suspeitos = new SelectList(_suspeitoApp.Listar(), "Id", "Nome");
                indexVM.Locais = new SelectList(_localApp.Listar(), "Id", "Nome");
                indexVM.Armas = new SelectList(_armaApp.Listar(), "Id", "Nome");
            }
            catch (Exception ex)
            {
                ExibirMensagem(ex.Message, TipoMensagem.Erro);
            }

            return View(indexVM);
        }

        [Route("Testemunha/{idArma}/{Idlocal}/{IdSuspeito}")]
        [HttpGet]
        public JsonResult Testemunha(int idArma, int Idlocal, int IdSuspeito)
        {
            try
            {
                var testemunha = _testemunhaService.Testemunha(idArma, Idlocal, IdSuspeito);     

                return Json(new { FlSucesso = true, Testemunha = testemunha });
            }
            catch (Exception ex)
            {
                return Json(new { FlSucesso = false, Mensagem = ex.Message });
            }
        }   
    }
}
