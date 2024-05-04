using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace FitnessCenter
{
    internal class Manager
    {
        private List<Client> _clients;

        public Manager()
        {
            _clients = LoadClientsFromJson("data.json");
        }

        private List<Client> LoadClientsFromJson(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
            var clientsArray = jsonObject["clients"].ToString();
            return JsonConvert.DeserializeObject<List<Client>>(clientsArray);
        }


        public List<Client> GetClients()
        {
            return _clients;
        }
    }
}
