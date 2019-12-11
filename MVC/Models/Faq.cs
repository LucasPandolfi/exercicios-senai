namespace MVC.Models
{
    public class Faq
    {
        public string Email {get; set;}
        public string Nome {get;set;}
        public string Duvidas {get;set;}

        public Faq()
        {

        }

        public Faq(string Email, string Nome, string Duvidas)
        {
            this.Email = Email;
            this.Nome = Nome;
            this.Duvidas = Duvidas;
        }
    }
}