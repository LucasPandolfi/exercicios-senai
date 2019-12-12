using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HomeController : AbstractController
    {
        FaqRepository faqRepository = new FaqRepository();
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new AgendamentoViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()               
            });
        }

        public IActionResult cadastrarPergunta(IFormCollection form)
        {
            try
            {
                Faq faq = new Faq(form["email"], form["Nome"], form["Duvida"]);

                faqRepository.Inserir(faq);

                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Home",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
