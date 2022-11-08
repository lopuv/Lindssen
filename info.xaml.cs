using Microsoft.VisualBasic;

namespace Lindssen_app;

public partial class info : ContentPage
{
	int choice;
	public info()
	{
		InitializeComponent();
	}

	private void Info_button_Clicked(object sender, EventArgs e)
	{
		if (choice == 0)
		{
            info_button.BackgroundColor = Colors.Red;
			choice++;
        }
		else if(choice == 1)
		{
			info_button.BackgroundColor = Colors.Blue;
			choice++;
		}
		else
		{
			info_button.BackgroundColor = Colors.Coral;
			choice = 0;
		}	

	}
}