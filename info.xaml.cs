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
			Getinfo();
        }

		public async void Getinfo()
		{
			HttpClient client = new HttpClient();

			var response = await client.GetStringAsync("https://yacht.yotem.nl/data.json");
            JsonProcess j = JsonConvert.DeserializeObject<JsonProcess>(response);
			appel.Text = j.username;
			peer.Text = j.password;
		}
    }
}