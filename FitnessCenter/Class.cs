using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Resources
{
    internal class Class
    {
        public string name { get; set; }

        public List<Client> clients { get; set; }
        public DateTime dateTime { get; set; }

        public bool isGroup { get; set; }

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

        public void appendClient(Client client) { if (!this.clients.Contains(client)) this.clients.Add(client); }
    }
}
