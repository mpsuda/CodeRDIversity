using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Controllers
{

    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
