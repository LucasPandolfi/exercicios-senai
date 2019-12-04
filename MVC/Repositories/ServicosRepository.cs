using System.Collections.Generic;
using System.IO;

namespace MVC.Repositories
{
    public class ServicosRepository
    {
        private const string PATH = "Database/ServicosAdicionais.csv";

        public ServicosRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<string> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<string> servicos = new List<string>();
            foreach (var linha in linhas)
            {
                servicos.Add(linha);
            }
            return servicos;
        }
    }
}