using Microsoft.AspNetCore.Mvc;
using BuscaEndereco.Models;

namespace BuscaEndereco.Controllers
{
    public class EnderecoController : Controller
    {
        [HttpGet]
        public IActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscar(EnderecoModel endereco)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", endereco);
            }

            return View(endereco);
        }
    }
}