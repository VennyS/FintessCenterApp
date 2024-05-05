﻿using FitnessCenter.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    internal class Employee
    {
        public string Name { get; set; }
        public string degree { get; set; }
        public List<Class> classes { get; set; }

        public Employee() { }
        public Employee(string name, string degree, List<Class> classes)
        {
            Name = name;
            this.degree = degree;
            this.classes = classes;
        }
    }
}