namespace Lindssen_app;

using System.Diagnostics;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button1_Clicked(object sender, EventArgs e)
	{
		Debug.WriteLine("the call comes from button");
	}
}

