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
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;

namespace Lindssen_app
{
    class JsonProcess
    {
        // process id in the api
        //public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string info { get; set; }

        private HttpClient client = new HttpClient();

        //user type?

        //TODO write input to json file

        //constructor?
        public JsonProcess() 
        {
        }

        public async Task Getinfo()
        {
            var response = await client.GetStringAsync("http://172.28.112.1/yacht/data.json");
            string j = JsonConvert.DeserializeObject<string>(response);
            this.info = j.ToString();
        }


        public async Task SaveData()
        {

            using var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://172.28.112.1/yacht/")
            };
      

            string json = JsonConvert.SerializeObject(this);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            //request.Content = new StringContent(this.username, Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
        }

    }
}
