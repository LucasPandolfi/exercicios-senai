using System;
using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories {
    public class AgendamentoRepository : RepositoryBase 
    {
        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository () 
        {
            if (!File.Exists (PATH)) 
            {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Agendamento agendamento) 
        {
            var quantidadeAgendamentos = File.ReadAllLines(PATH).Length;
            agendamento.Id = (ulong) ++quantidadeAgendamentos;
            var linha = new string[] { PrepararAgendamentoCSV (agendamento)};
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Agendamento> ObterTodosPorCliente (string emailCliente) 
        {
            var agendamentos = ObterTodos ();
            List<Agendamento> agendamentosCliente = new List<Agendamento> ();
            foreach (var agendamento in agendamentos) 
            {
                if (agendamento.cliente.Email.Equals (emailCliente)) 
                {
                    agendamentosCliente.Add (agendamento);
                }
            }
            return agendamentosCliente;
        }

        public List<Agendamento> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Agendamento> agendamentos = new List<Agendamento> ();
            foreach (var linha in linhas) 
            {
                Agendamento agendamento = new Agendamento ();

                agendamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                agendamento.Status = uint.Parse(ExtrairValorDoCampo("status_agendamento", linha));
                agendamento.cliente.Email = ExtrairValorDoCampo ("cliente_email", linha);
                agendamento.cliente.Cpf_cnpj = ExtrairValorDoCampo ("cliente_cpf/cnpj", linha);
                agendamento.cliente.Telefone = ExtrairValorDoCampo ("cliente_telefone", linha);
                agendamento.NomeEvento = ExtrairValorDoCampo ("nome_evento", linha);
                agendamento.DescricaoEvento = ExtrairValorDoCampo ("cliente_descricao", linha);
                /* agendamento.ImagemEvento = ExtrairValorDoCampo("url_Fotos", linha);*/
                agendamento.pubpriv = ExtrairValorDoCampo ("cliente_pubpriv", linha);
                agendamento.DataEvento = DateTime.Parse (ExtrairValorDoCampo ("data_agendamento", linha));
                agendamento.Servicos = ExtrairValorDoCampo ("servicos", linha);
                agendamento.formasPagamento = ExtrairValorDoCampo ("formas_pagamento", linha);
                agendamento.PrecoTotal = double.Parse (ExtrairValorDoCampo ("preco_total", linha));
                agendamentos.Add(agendamento);
            }
            return agendamentos;
        }

        public Agendamento ObterPor(ulong id)
        {
            var agendamentosTotais = ObterTodos();
            foreach (var agendamento in agendamentosTotais)
            {
                if(id.Equals(agendamento.Id))
                {
                    return agendamento;
                }
            }
            return null;
        }

        public bool Atualizar(Agendamento agendamento)
        {
            var agendamentosTotais = File.ReadAllLines(PATH);
            var agendamentoCSV = PrepararAgendamentoCSV(agendamento);
            var linhaAgendamento = -1;
            var resultado = false;

            for (int i = 0; i <agendamentosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", agendamentosTotais[i]));
                if(agendamento.Id.Equals(idConvertido))
                {
                    linhaAgendamento = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                agendamentosTotais[linhaAgendamento] = agendamentoCSV;
                File.WriteAllLines(PATH, agendamentosTotais);
            }
            return resultado;
        }

        private string PrepararAgendamentoCSV (Agendamento agendamento) {
            Cliente c = agendamento.cliente;

            return $"id={agendamento.Id};status_agendamento={agendamento.Status};cliente_email={c.Email};cliente_cpf/cnpj={c.Cpf_cnpj};cliente_telefone={c.Telefone};nome_evento={agendamento.NomeEvento};cliente_descricao={agendamento.DescricaoEvento};cliente_pubpriv={agendamento.pubpriv};data_agendamento={agendamento.DataEvento};servicos={agendamento.Servicos};formas_pagamento={agendamento.formasPagamento};preco_total={agendamento.PrecoTotal}";
        }
    }
}