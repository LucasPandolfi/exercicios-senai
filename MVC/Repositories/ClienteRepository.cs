using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);
                    c.Cpf_cnpj = ExtrairValorDoCampo("cpf", item);

                    return c;
                }
            }
            return null;
            
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"email={cliente.Email},senha={cliente.Senha},cpf={cliente.Cpf_cnpj},nome={cliente.Nome},data_nascimento={cliente.DataNascimento},telefone={cliente.Telefone}";
        }
    }
}