using App_FGNC.Controllers;

namespace App_FGNC.Views;

public partial class LoginPage : ContentPage
{
    AuthController controller = new AuthController();

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        bool sucesso = controller.Login(txtUsuario.Text, txtSenha.Text);

        if (sucesso)
        {
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            lblMensagem.Text = "Login inválido!";
        }
    }
}
