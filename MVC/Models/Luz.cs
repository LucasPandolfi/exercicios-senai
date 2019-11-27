namespace MVC.Models
{
    public class Luz : Servicos
    {
        public Luz()
        {

        }
        public Luz(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco; 
        }
    }
}