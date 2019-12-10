using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Enums;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class CadastroController : AbstractController
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Cadastro()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
                
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Seu cadastro";
            try
            {
                Cliente cliente = new Cliente(form["email"], form["senha"], form["cpf"], form["nome"], DateTime.Parse(form["data_nascimento"]), form["telefone"]);

                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                clienteRepository.Inserir(cliente);
                
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
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
    }
}