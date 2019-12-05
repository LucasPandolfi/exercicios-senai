using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AlugarController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        PagamentoRepository pagamentoRepository = new PagamentoRepository();
        ServicosRepository servicosRepository = new ServicosRepository();

        public IActionResult Alugar()
        {
            AgendamentoViewModel avm = new AgendamentoViewModel();
            avm.FormasDePagamento = pagamentoRepository.ObterTodos();
            avm.servicos = servicosRepository.ObterTodos();

            return View(avm);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Agendamento agendamento = new Agendamento();

            Cliente cliente = new Cliente();
            cliente.Email = form["email"];
            cliente.Cpf_cnpj = form["cpf_cnpj"];
            cliente.Telefone = form["telefone"];
            agendamento.NomeEvento = form["nome_do_evento"];
            agendamento.DescricaoEvento = form["descricao"];
            agendamento.Servicos = form["servicos"];
            agendamento.pubpriv = form["priv_pub"];
            agendamento.formasPagamento = form["pagamento"];

            agendamento.cliente = cliente;

            agendamento.DataEvento = DateTime.Now;

            

            if(agendamentoRepository.Inserir(agendamento))
            { 
            return View("Sucesso", new RespostaViewModel() 
            {
                NomeView = "Agendamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
            else
            {
                return View("Erro", new RespostaViewModel());
            }
        }
    }
}