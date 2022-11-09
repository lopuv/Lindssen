using Microsoft.VisualBasic;

namespace Lindssen_app;

public partial class info : ContentPage
{
	public info()
	{
		InitializeComponent();
	}

	private void Info_button_Clicked(object sender, EventArgs e)
	{
		info_button.Text = "appel";
	}
}