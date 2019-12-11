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

        // PRECISO TERMINAR O FAQ. CREIO QUE ESTOU USANDO E CRIANDO UM MODEL DESNECESSARIO. 
        public IActionResult Teste()
        {
            AgendamentoViewModel faq = new AgendamentoViewModel();
            var usuarioLogado = ObterUsuarioSession();
            Cliente cliente = new Cliente();

            faq.Cliente = clienteRepository.ObterPor(usuarioLogado);     
            return View(faq);
        }

        public IActionResult cadastrarPergunta(IFormCollection form)
        {
            try
            {
                Faq faq = new Faq(form["Email"], form["Nome"], form["Duvida"]);

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
