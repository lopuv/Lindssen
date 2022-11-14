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

			var response = await client.GetStringAsync("http://192.168.178.143/yachts/data.json");
			User useR = JsonConvert.DeserializeObject<User>(response);
			banaan.Text = useR.Id;
		}

      
    }

    public class User
	{
		public string Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}