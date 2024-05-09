using FitnessCenter.Resources;
using System.Collections.Generic;

namespace FitnessCenter
{
    internal class Employee
    {
        public string name { get; set; }
        public string degree { get; set; }
        public List<Class> classes { get; set; }

        public Employee() { }
        public Employee(string name, string degree, List<Class> classes)
        {
            this.name = name;
            this.degree = degree;
            this.classes = classes;
        }
    }
}
