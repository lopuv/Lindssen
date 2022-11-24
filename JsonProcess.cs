using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net.Http;

namespace Lindssen_app
{
    class JsonProcess
    {
        // process id in the api
        //public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        private HttpClient client = new HttpClient();

        //user type?

        //TODO write input to json file

        //constructor?
        public JsonProcess() 
        {
        }

        public async void Getinfo()
        {
            var response = await client.GetStringAsync("https://yacht.yotem.nl/data.json");
            JsonProcess j = JsonConvert.DeserializeObject<JsonProcess>(response);
            j.username = this.username;
            j.password = this.password;
        }


        public void SaveData(bool isNewUser = false)
        {

            string json = JsonConvert.SerializeObject(this);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            if (isNewUser)
            {
                //look how this function works
                client.PostAsync("http://192.168.178.143/yacht/data.json", content).ConfigureAwait(false);
            }
            else
            {
                client.PutAsync("http://192.168.178.143/yacht/data.json", content).ConfigureAwait(false);
            }
        }

    }
}
