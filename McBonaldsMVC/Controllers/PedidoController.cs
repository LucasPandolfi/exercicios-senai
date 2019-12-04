using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        public IActionResult Index()
        {

            var Hamburgueres = hamburguerRepository.ObterTodos();
            var shakes = shakeRepository.ObterTodos1();

            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.shake = shakeRepository.ObterTodos1();

            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = emailCliente;
            pvm.UsuarioNome = nomeUsuario;

            return View(pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {

            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];
            Shake shake = new Shake(nomeShake, shakeRepository.ObterPrecoDe1(nomeShake));

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer(nomeHamburguer, hamburguerRepository.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.cliente = cliente; 

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepository.Inserir(pedido))
            { 
            return View("Sucesso", new RespostaViewModel() 
            {
                NomeView = "Pedido",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
            else
            {
                return View("Erro");
            }
        }
    
    
        public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}