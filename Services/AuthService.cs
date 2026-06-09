using App_FGNC.Services;
using Microsoft.Maui.Storage;

namespace App_FGNC.Controllers
{
    public class AuthController
    {
        private AuthService _service = new AuthService();

        public bool Login(string usuario, string senha)
        {
            bool sucesso = _service.Login(usuario, senha);

            if (sucesso)
            {
                Preferences.Default.Set("isLoggedIn", true);
                Preferences.Default.Set("usuario", usuario);
            }

            return sucesso;
        }

        public void Logout()
        {
            Preferences.Default.Clear();
        }
    }
}
