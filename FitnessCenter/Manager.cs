using FitnessCenter.Resources;
using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    internal class Manager
    {
        private List<Client> _clients;
        private List<Class> _groupClasses;

        public Manager()
        {
            _clients = new List<Client>{
            new Client("Иван Иванов", new DateTime(1990, 5, 10), 75, 180, 7),
            new Client("Мария Петрова", new DateTime(1985, 12, 20), 62, 165, 7),
            new Client("Алексей Сидоров", new DateTime(1988, 8, 15), 80, 175, 7),
            new Client("Елена Козлова", new DateTime(1992, 3, 25), 68, 170, 7),
            new Client("Павел Николаев", new DateTime(1995, 11, 8), 85, 185, 7),
            new Client("Анна Смирнова", new DateTime(1983, 9, 30), 70, 160, 7),
            new Client("Дмитрий Игнатьев", new DateTime(1993, 7, 12), 78, 175, 7)
            };

            _groupClasses = new List<Class>
            {
                new Class("Йога", new DateTime(2024, 5, 6, 9, 0, 0)),
                new Class("Йога", new DateTime(2024, 5, 6, 16, 30, 0)),
                new Class("Стретчинг", new DateTime(2024, 5, 4, 10, 30, 0)),
                new Class("Стретчинг", new DateTime(2024, 5, 4, 18, 0, 0)),
                new Class("Аэробика", new DateTime(2024, 5, 6, 11, 0, 0)),
                new Class("Аэробика", new DateTime(2024, 5, 6, 17, 30, 0)),
                new Class("Функциональная тренировка", new DateTime(2024, 5, 4, 13, 0, 0)),
                new Class("Функциональная тренировка", new DateTime(2024, 5, 4, 19, 0, 0))
            };
        }

        public List<Client> GetClients() {  return _clients; }

        public List<Class> GetClasses() { return _groupClasses; }
    }
}
