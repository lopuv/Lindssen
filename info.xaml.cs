using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Configuration;


namespace Lindssen_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class info : ContentPage
	{

        public info()
		{
			InitializeComponent();
        }

        private void citroen_Clicked(object sender, EventArgs e)
        {
			Display_info();
        }

		public void Display_info()
		{	
			JsonProcess j = new JsonProcess();
			appel.Text = j.username;
			peer.Text = j.password;
		}
    }
}