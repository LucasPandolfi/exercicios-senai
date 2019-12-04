using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Agendamento eventos)
        {
            return true;
        }

        public List<Agendamento> ObterTodosPorCliente(string emailCliente)
        {
            var agendamentos = ObterTodos();
            List<Agendamento> agendamentosCliente = new List<Agendamento>();
            foreach (var agendamento in agendamentos)
            {
                if(agendamento.cliente.Email.Equals(emailCliente))
                {
                    agendamentosCliente.Add(agendamento);
                }
            }
                return agendamentosCliente;
        }

        public List<Agendamento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendamento> agendamentos = new List<Agendamento>();
            foreach (var linha in linhas)
            {
                Agendamento agendamento = new Agendamento();


            }
            return agendamentos;
        }

        private string PrepararAgendamentoCSV(Agendamento agendamento)
        {
            Cliente c = agendamento.cliente;
            

            return $"nome_evento={agendamento.NomeEvento};cliente_email={c.Email};cliente_cpf/cnpj={c.Cpf_cnpj};cliente_telefone={c.Telefone};cliente_pubpriv={agendamento.pubpriv};data_agendamento={agendamento.DataEvento};";
        }
    }
}