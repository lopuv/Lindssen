namespace Lindssen_app;

using System.Diagnostics;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button1_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new info());
	}

}

