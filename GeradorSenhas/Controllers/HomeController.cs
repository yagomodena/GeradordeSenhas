using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;

namespace PasswordGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GeradorSenhas(int tamanho)
        {
            string caracteresValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            StringBuilder senha = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < tamanho; i++)
            {
                int index = random.Next(caracteresValidos.Length);
                senha.Append(caracteresValidos[index]);
            }

            ViewData["GeradorSenhas"] = senha.ToString();
            return View("Index");
        }
    }
}