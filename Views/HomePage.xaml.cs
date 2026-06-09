using App_FGNC.Controllers;
using Microsoft.Maui.Storage;

namespace App_FGNC.Views;

public partial class HomePage : ContentPage
{
    AuthController controller = new AuthController();

    public HomePage()
    {
        InitializeComponent();

        string user = Preferences.Default.Get("usuario", "");
        lblUser.Text = $"Bem-vindo {user}";
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        controller.Logout();
        Application.Current.MainPage = new LoginPage();
    }
}
