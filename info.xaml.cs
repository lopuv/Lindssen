using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Configuration;


namespace Lindssen_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class info : ContentPage
	{
		JsonProcess j = new JsonProcess();

        public info()
		{
			InitializeComponent();
        }

        private async void citroen_Clicked(object sender, EventArgs e)
        {
            await j.Getinfo();
            appel.Text = j.info;
        }
    }
}