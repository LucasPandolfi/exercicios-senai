using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Enums;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AlugarController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        /* Agendamento agendamento = new Agendamento();*/
        PagamentoRepository pagamentoRepository = new PagamentoRepository();
        ServicosRepository servicosRepository = new ServicosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Alugar()
        {
            AgendamentoViewModel avm = new AgendamentoViewModel();
            avm.FormasDePagamento = pagamentoRepository.ObterTodos();
            avm.servicos = servicosRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeUsuario = nomeUsuarioLogado;
                var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
                avm.Cliente = clienteLogado;
            }
            else
            {
                return View (avm);
            }
            
            avm.NomeView = "Reservar";
            avm.UsuarioEmail = usuarioLogado;
            avm.UsuarioNome = nomeUsuarioLogado; 

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

            agendamento.DataEvento = DateTime.Parse(form["dataevento"]);

            double precoDefinitivo = servicosRepository.ObterPrecoTotal(agendamento.Servicos);

            agendamento.PrecoTotal = precoDefinitivo;

            /* var urlFoto = $"wwwroot\\{PATH_FOTOS}";

            GravarFoto(form.Files, urlFoto);

            agendamento.ImagemEvento = urlFoto;*/

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

        /* public async void GravarFoto(IFormFileCollection arquivos, string urlFoto) 
        { 
            foreach (var foto in arquivos)
            {   
                System.IO.Directory.CreateDirectory(urlFoto).Create();
                var file = System.IO.File.Create(urlFoto + foto.FileName);
                await foto.CopyToAsync(file);
                file.Close();
            }
        }*/

        /* public IActionResult TratarUrl()
        {
            var urlFoto = Directory.GetFiles(agendamento.ImagemEvento).FirstOrDefault();
            var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\","/").Replace("wwwroot", "");

            return View("Sucesso", new RespostaViewModel() 
            {
                NomeView = "Agendamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
            });
        }*/

        public IActionResult Aprovar(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.APROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este agendamento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Pendente(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.PENDENTE;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult PendenteAprovado(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.PENDENTE;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Aprovado", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult PendenteReprovado(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.PENDENTE;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Reprovado", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Reprovar(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.REPROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este agendamento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}