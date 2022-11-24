namespace Lindssen_app;

public partial class Mainpage2 : ContentPage
{
	public Mainpage2()
	{
		InitializeComponent();
	}

    private async void Button1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new info());
    }
}