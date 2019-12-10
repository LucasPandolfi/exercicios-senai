using Microsoft.AspNetCore.Mvc;
using MVC.Enums;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public IActionResult Dashboard()
        {
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            if (!ninguemLogado && (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
            var agendamentos = agendamentoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            foreach (var agendamento in agendamentos)
            {
                switch(agendamento.Status)
                {
                    case (uint) StatusAgendamento.APROVADO:
                        dashboardViewModel.AgendamentosAprovados++;
                    break;
                    case (uint) StatusAgendamento.REPROVADO:
                    dashboardViewModel.AgendamentosReprovados++;
                    break;
                    default:
                        dashboardViewModel.AgendamentosPendentes++;
                        dashboardViewModel.Agendamentos.Add(agendamento);
                    break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();

            return View(dashboardViewModel);
            }
            else
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o dashboard"
                });
            }
        }
    }
}