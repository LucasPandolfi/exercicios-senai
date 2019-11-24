using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repositories;

namespace MVC.Controllers
{
    public class CadastroController : Controller
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Seu cadastro";
            try
            {
                Cliente cliente = new Cliente(form["email"], form["senha"], form["cpf"], form["nome"], DateTime.Parse(form["data_nascimento"]), form["telefone"]);

                clienteRepository.Inserir(cliente);
                
                return View("Sucesso");
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}