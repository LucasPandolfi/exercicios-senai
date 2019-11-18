using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.shake = shakeRepository.ObterTodos1();

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
            return View("Sucesso");
            }
            else
            {
                return View("Erro");
            }
        }
    }
}