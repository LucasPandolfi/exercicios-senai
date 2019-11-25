using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class ClienteController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("========================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                        return RedirectToAction("Historico", "Cliente");//Aqui estamos usando redirecttoaction pois, ele irá "matar o viewdata"
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta")); 
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado")); //Ao inves de chamar esta mensagem salvando ela em uma variavel, neste caso como é uma pequena mensagem, basta instanciar o objeto dentro do parametro
                }

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}