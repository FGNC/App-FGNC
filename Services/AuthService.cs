namespace App_FGNC.Services
{
    public class AuthService
    {
        public bool Login(string usuario, string senha)
        {
            return usuario == "admin" && senha == "1234";
        }
    }
}
