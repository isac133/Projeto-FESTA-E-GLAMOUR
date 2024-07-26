using Microsoft.AspNetCore.Mvc;
using Projeto_Festa_e_Glamour.Models;
using System.Diagnostics;

namespace Projeto_Festa_e_Glamour.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly ILogger<AgendamentoController> _logger;

        public AgendamentoController(ILogger<AgendamentoController> logger)
        {
            _logger = logger;
        }

        public IActionResult AgendamentoClienteIndex()
        {
            return View();
        }

        public IActionResult CadastroAgendamento()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
