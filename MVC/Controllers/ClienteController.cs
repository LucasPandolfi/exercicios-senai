using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Enums;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class ClienteController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View( new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
                
            });
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
                        switch(cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Historico", "Cliente");//Aqui estamos usando redirecttoaction pois, ele irá "matar o viewdata"
                            
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                                return RedirectToAction("Dashboard", "Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta")); 
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado")); 
                }

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel(e.Message));
            }
        }

        public IActionResult Historico ()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var agendamentosCliente = agendamentoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                agendamento = agendamentosCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}