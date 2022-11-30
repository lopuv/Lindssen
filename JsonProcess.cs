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
        public string username { get; set; }
        public string password { get; set; }
        public string info { get; set; }

        private HttpClient client = new HttpClient();

        public async Task Getinfo()
        {
            var response = await client.GetStringAsync("https://yacht.yotem.nl/data.json");
            string j = JsonConvert.DeserializeObject<string>(response);
            this.info = j.ToString();
        }


        public async Task SaveData()
        {

            using var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://yacht.yotem.nl/")
            };

            string json = JsonConvert.SerializeObject(this);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
        }

    }
}
