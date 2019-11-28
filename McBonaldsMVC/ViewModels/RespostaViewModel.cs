namespace McBonaldsMVC.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}

        public RespostaViewModel()
        {

        }

//Estamos criando essa area e colocando ela no shared de erro para mandar uma mensagem mais especifica do usuario 
        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}