using System;
using System.Collections.Generic;

namespace FitnessCenter.Resources
{
    internal class Class
    {
        public string name { get; set; }

        public List<Client> clients { get; set; }
        public DateTime dateTime { get; set; }

        public bool isGroup { get; set; }

        public string textForVisits { get { return this.dateTime.ToString("dd.MM.yyyy HH:mm") + $" направление: {this.name.ToLower()}"; } }

        public Class() { }

        public Class(string name, DateTime dateTime, bool isGroup = true)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.isGroup = isGroup;
        }

        public void setClients(List<Client> clients)
        {
            this.clients = clients;
        }

        public void appendClient(Client client)
        {
            if (!(this.clients is null))
            {
                if (!this.clients.Contains(client)) this.clients.Add(client);
            }
            else this.clients = new List<Client>() { client };
        }

        public void removeClient(Client client) {  this.clients.Remove(client); }
    }
}
