using LojaWeb.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace LojaWeb.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Política de Privacidade";
            ViewBag.Nome = "Lucas";
            Mensagem("Tela de Privacidade", "Info");
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem("Insira um nome", "Erro");
                return View();
            }

            // Você pode adicionar aqui a lógica de salvar dados ou fazer algo com os valores recebidos
            Mensagem("Dados salvos com sucesso", "Success");

            // Retornar a view de 'Privacy' ou redirecionar para outra página, se necessário
            return RedirectToAction("Privacy");
        }
    } 
}