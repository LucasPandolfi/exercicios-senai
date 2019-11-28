using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class SomRepository
    {
        private const string PATH = "Database/Som.csv";

        public List<Som> ObterLuz()
        {
            List<Som> som = new List<Som>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Som S = new Som();
                string[] dados = linha.Split(";");
                S.Nome = dados[0];
                S.Preco = double.Parse(dados[1]);
                som.Add(S);
            }
            return som;
        }
    }
}