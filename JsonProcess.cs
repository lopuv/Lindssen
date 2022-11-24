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

        //user type?

        //TODO write input to json file

        //constructor?
        public JsonProcess() 
        {
        }

        public async Task SaveData(bool isNewUser = false)
        {
            HttpClient client = new HttpClient();


            string json = JsonConvert.SerializeObject(this);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            if (isNewUser)
            {
                //look how this function works
                await client.PostAsync("https://yacht.yotem.nl", content);
            }
            else
            {
                await client.PutAsync("https://yacht.yotem.nl", content);
            }
        }

    }
}
