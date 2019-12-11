using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class FaqRepository : RepositoryBase
    {
        private const string PATH_FAQ = "Database/Faq.csv";
        public FaqRepository()
        {
            if(!File.Exists(PATH_FAQ))
            {
                File.Create(PATH_FAQ).Close();
            }
        }
        public bool Inserir(Faq faq)
        {
            var linha = new string[] {PrepararRegistroCSV(faq)};
            File.AppendAllLines(PATH_FAQ, linha);

            return true;
        }

        public Faq ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH_FAQ);
            foreach (var linha in linhas)
            {
                if(ExtrairValorDoCampo("Email", linha).Equals(email))
                {
                    Faq f = new Faq();
                    f.Email = ExtrairValorDoCampo("Email", linha);
                    f.Nome = ExtrairValorDoCampo("Nome", linha);
                    f.Duvidas = ExtrairValorDoCampo("Duvida", linha);

                    return f;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV(Faq faq)
        {
            return $"Email={faq.Email};Nome={faq.Nome};Duvida={faq.Duvidas}";
        }
    }
}