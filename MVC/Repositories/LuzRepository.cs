using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class LuzRepository
    {
        private const string PATH = "Database/Luz.csv";

        public List<Luz> ObterLuz()
        {
            List<Luz> luz = new List<Luz>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Luz L = new Luz();
                string[] dados = linha.Split(";");
                L.Nome = dados[0];
                L.Preco = double.Parse(dados[1]);
                luz.Add(L);
            }
            return luz;
        }
    }
}