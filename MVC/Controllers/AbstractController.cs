using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "email_cliente";//Criamos o abstract para fazer uma ponte entre o pedidocontroller e o clientecontroller
        protected const string SESSION_CLIENTE_NOME= "nome_cliente";
        protected const string SESSION_CLIENTE_TIPO= "nome_tipo";
        protected const string PATH_FOTOS = "images\\fotos";

        protected string ObterUsuarioSession()
        {
            var usuario = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(!string.IsNullOrEmpty(usuario))
            {
                return usuario;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioTipoSession()
        {
            var tipousuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if(!string.IsNullOrEmpty(tipousuario))
            {
                return tipousuario;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession()
        {
            var nomeUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                return nomeUsuario;
            }
            else
            {
                return "";
            }
        }
    }
}