using MySqlX.XDevAPI;
using System.Diagnostics;
using System.Text;

namespace Lindssen_app;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void login_Clicked(object sender, EventArgs e)
	{
		JsonProcess j = new JsonProcess();
		if (username.Text == null)
		{
			await DisplayAlert("Username", "username can not be empty", "ok");
		}
		else if(password.Text == null)
		{
            await DisplayAlert("Password", "password can not be empty", "ok");
        }
		else
		{
			j.username= username.Text;
			j.password = password.Text;
			await j.SaveData(true);
        }
    }
}

