using System;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
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
            ViewData["Action"] = "login";//Aqui temos um problema, pois este login esta direcionado para carregar minha tela de login, ou seja, quando o usuario apertar na opção de login ele irá voltar para a mesma. como carregar a pagina certa ???
            //O problema acima foi resolvido criando um historico... para acesssar o historico ir até Views-Cliente.
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
    
        public IActionResult Historico ()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                pedidos = pedidosCliente
            });
        }
    }
}
