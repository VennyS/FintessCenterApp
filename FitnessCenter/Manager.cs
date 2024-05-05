using FitnessCenter.Resources;
using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    internal class Manager
    {
        private List<Client> _clients;
        private List<Class> _groupClasses;
        private List<Employee> _employees;

        public Manager()
        {
            _clients = new List<Client>{
                new Client("Иван Иванов", new DateTime(1990, 5, 10), 75, 180, 7, new Dictionary<string, int> {{"Май", 5}, {"Апрель", 3}}),
                new Client("Мария Петрова", new DateTime(1985, 12, 20), 62, 165, 7, new Dictionary<string, int> {{"Декабрь", 4}, {"Ноябрь", 2}}),
                new Client("Алексей Сидоров", new DateTime(1988, 8, 15), 80, 175, 7, new Dictionary<string, int> {{"Август", 6}, {"Июль", 3}}),
                new Client("Елена Козлова", new DateTime(1992, 3, 25), 68, 170, 7, new Dictionary<string, int> {{"Март", 3}, {"Февраль", 2}}),
                new Client("Павел Николаев", new DateTime(1995, 11, 8), 85, 185, 7, new Dictionary<string, int> {{"Ноябрь", 8}, {"Октябрь", 2}}),
                new Client("Анна Смирнова", new DateTime(1983, 9, 30), 70, 160, 7, new Dictionary<string, int> {{"Сентябрь", 2}, {"Август", 2}}),
                new Client("Дмитрий Игнатьев", new DateTime(1993, 7, 12), 78, 175, 7, new Dictionary<string, int> {{"Июль", 7}, {"Июнь", 2}})
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
                new Class("Функциональная тренировка", new DateTime(2024, 5, 4, 19, 0, 0)),
                new Class("Силовая", new DateTime(2024, 5, 6, 9, 0, 0)),
                new Class("Силовая", new DateTime(2024, 5, 6, 16, 30, 0)),
                new Class("Растяжка", new DateTime(2024, 5, 6, 9, 0, 0)),
                new Class("Растяжка", new DateTime(2024, 5, 6, 16, 30, 0)),
            };

            // Добавляем случайных клиентов к каждому занятию
            _groupClasses[0].setClients(new List<Client> { _clients[0], _clients[1] });
            _groupClasses[1].setClients(new List<Client> { _clients[2], _clients[3] });
            _groupClasses[2].setClients(new List<Client> { _clients[4], _clients[5] });
            _groupClasses[3].setClients(new List<Client> { _clients[6], _clients[0] });
            _groupClasses[4].setClients(new List<Client> { _clients[1], _clients[2] });
            _groupClasses[5].setClients(new List<Client> { _clients[3], _clients[4] });
            _groupClasses[6].setClients(new List<Client> { _clients[5], _clients[6] });
            _groupClasses[7].setClients(new List<Client> { _clients[0], _clients[2] });

            // Добавляем занятия к каждому клиенту
            _clients[0].setClasses(new List<Class> { _groupClasses[0], _groupClasses[3], _groupClasses[7] });
            _clients[1].setClasses(new List<Class> { _groupClasses[0], _groupClasses[4] });
            _clients[2].setClasses(new List<Class> { _groupClasses[1], _groupClasses[4], _groupClasses[7] });
            _clients[3].setClasses(new List<Class> { _groupClasses[1], _groupClasses[5] });
            _clients[4].setClasses(new List<Class> { _groupClasses[2], _groupClasses[5] });
            _clients[5].setClasses(new List<Class> { _groupClasses[2], _groupClasses[6] });
            _clients[6].setClasses(new List<Class> { _groupClasses[3], _groupClasses[6] });

            _employees = new List<Employee>
            {
                new Employee("Иванов Иван", "тренер высшей категории", new List<Class> { _groupClasses[8], _groupClasses[9] }),
                new Employee("Петров Петр", "тренер средней категории", new List<Class> { _groupClasses[10], _groupClasses[11] }),
                new Employee("Сидоров Сидор", "тренер высшей категории", new List<Class> { _groupClasses[8], _groupClasses[11] }),
                new Employee("Александров Александр", "тренер средней категории", new List<Class> { _groupClasses[9], _groupClasses[10] })
            };
        }

        public List<Client> GetClients() {  return _clients; }

        public List<Class> GetClasses() { return _groupClasses; }
    }
}
