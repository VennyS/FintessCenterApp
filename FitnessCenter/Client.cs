using FitnessCenter.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    internal class Client
    {
        public string full_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public DateTime registration_date { get; set; }
        public int weight_kg { get; set; }
        public int height_cm { get; set; }
        public int remaining_visits { get; set; }

        public Dictionary<string, int> visitsPerMonth { get; set; }

        public List<Class> classes { get; set; }

        public Client() { }

        public Client(string full_name, DateTime date_of_birth, int weight_kg, int height_cm, int remaining_visits, Dictionary<string, int> visitsPerMonth = null)
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.weight_kg = weight_kg;
            this.height_cm = height_cm;
            this.remaining_visits = remaining_visits;
            this.visitsPerMonth = visitsPerMonth;
            this.registration_date = DateTime.Now;
        }
        public Client(string full_name, DateTime date_of_birth, int weight_kg, int height_cm, int remaining_visits, DateTime registration_date, Dictionary<string, int> visitsPerMonth = null )
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.weight_kg = weight_kg;
            this.height_cm = height_cm;
            this.remaining_visits = remaining_visits;
            this.visitsPerMonth = visitsPerMonth;
            this.registration_date = registration_date;
        }

        public Client(string full_name, DateTime date_of_birth, int weight_kg, int height_cm)
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.weight_kg = weight_kg;
            this.height_cm = height_cm;
        }

        public void addAbonement(int count) { remaining_visits += count; }

        public void setClasses(List<Class> classes) { this.classes = classes; }

        public void appendClass(Class @class) { if (!this.classes.Contains(@class)) this.classes.Add(@class); }
        public void removeClass(Class @class) { this.classes.Remove(@class); }
    }
}
