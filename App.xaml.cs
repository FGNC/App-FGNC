using App_FGNC.Views;
using Microsoft.Maui.Storage;

namespace App_FGNC;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        bool isLogged = Preferences.Default.Get("isLoggedIn", false);

        if (isLogged)
            MainPage = new AppShell();
        else
            MainPage = new LoginPage();
    }
}
