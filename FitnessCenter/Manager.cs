using FitnessCenter.Resources;
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
        private List<GroupClass> _groupClasses;

        public Manager()
        {
            _clients = LoadClientsFromJson("data.json");
            _groupClasses = LoadClassesFromJSON("data.json");
        }

        private List<Client> LoadClientsFromJson(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
            var clientsArray = jsonObject["clients"].ToString();
            return JsonConvert.DeserializeObject<List<Client>>(clientsArray);
        }

        private List<GroupClass> LoadClassesFromJSON(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
            var classesArray = jsonObject["group_classes"].ToString();
            return JsonConvert.DeserializeObject<List<GroupClass>>(classesArray);            
        }


        public List<Client> GetClients()
        {
            return _clients;
        }

        public List<GroupClass> GetClasses()
        {
            return _groupClasses;
        }
    }
}
