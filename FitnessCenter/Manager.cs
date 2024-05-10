using FitnessCenter.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace FitnessCenter
{
    internal class Manager
    {
        private List<Client> _clients;
        private List<Class> _groupClasses;
        private List<Employee> _employees;
        private static Dictionary<string, int> _income;

        public Manager()
        {
            _clients = new List<Client>
            { 
                new Client("Иван Иванов", new DateTime(1990, 5, 10), 75, 180, 7, new DateTime(2024, 2, 1), new Dictionary<string, int> {{"Март", 5}, {"Апрель", 3}}),
                new Client("Мария Петрова", new DateTime(1985, 12, 20), 62, 165, 7, new DateTime(2024, 3, 1), new Dictionary<string, int> {{"Апрель", 4}, {"Май", 2}}),
                new Client("Алексей Сидоров", new DateTime(1988, 8, 15), 80, 175, 7, new DateTime(2024, 1, 1), new Dictionary<string, int> {{"Февраль", 6}, {"Март", 3}}),
                new Client("Елена Козлова", new DateTime(1992, 3, 25), 68, 170, 7, new DateTime(2024, 2, 1), new Dictionary<string, int> {{"Март", 3}, {"Апрель", 2}}),
                new Client("Павел Николаев", new DateTime(1995, 11, 8), 85, 185, 7, new DateTime(2024, 1, 1), new Dictionary<string, int> {{"Февраль", 8}, {"Апрель", 2}}),
                new Client("Анна Смирнова", new DateTime(1983, 9, 30), 70, 160, 7, new DateTime(2024, 3, 1), new Dictionary < string, int > { { "Апрель", 2 }, { "Май", 2 } }),
                new Client("Дмитрий Игнатьев", new DateTime(1993, 7, 12), 78, 175, 7, new DateTime(2024, 1, 1), new Dictionary < string, int > { { "Февраль", 7 }, { "Март", 2 } })
            };

            _groupClasses = new List<Class>
            {
                new Class("Йога", new DateTime(2024, 5, 10, 9, 0, 0)),
                new Class("Йога", new DateTime(2024, 5, 10, 16, 30, 0)),
                new Class("Стретчинг", new DateTime(2024, 5, 10, 10, 30, 0)),
                new Class("Стретчинг", new DateTime(2024, 5, 10, 18, 0, 0)),
                new Class("Аэробика", new DateTime(2024, 5, 12, 11, 0, 0)),
                new Class("Аэробика", new DateTime(2024, 5, 12, 17, 30, 0)),
                new Class("Функциональная тренировка", new DateTime(2024, 5, 12, 13, 0, 0)),
                new Class("Функциональная тренировка", new DateTime(2024, 5, 12, 19, 0, 0)),
                new Class("Силовая", new DateTime(2024, 5, 14, 9, 0, 0), false),
                new Class("Силовая", new DateTime(2024, 5, 14, 16, 30, 0), false),
                new Class("Растяжка", new DateTime(2024, 5, 14, 9, 0, 0), false),
                new Class("Растяжка", new DateTime(2024, 5, 14, 16, 30, 0), false),
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

            _income = new Dictionary<string, int>
            {
                ["Февраль"] = 390000,
                ["Март"] = 410000,
                ["Апрель"] = 370000,
                ["Май"] = 400000,
            };
        }

        public void AddIncome(int income, DateTime date)
        {
            string month = date.ToString("MMMM", new System.Globalization.CultureInfo("ru-RU"));
            AddIncome(income, month);
        }

        public void AddIncome(int income,  string month)
        {
            if (_income.ContainsKey(month)) { _income[month] += income; }
            else { _income[month] = income; }
        }

        public Dictionary<string, int> GetIncomeInThousand()
        {
            Dictionary<string, int> incomeInThosand = new Dictionary<string, int>();
            for (int i = 0; i < _income.Keys.Count; i++)
            {
                var incomeKey = _income.Keys.ElementAt(i);
                incomeInThosand[incomeKey] = (int)Math.Round(_income[incomeKey] / 100000.0);
            }
            return incomeInThosand;
        }

        public int GetIncomeInThousand(DateTime date)
        {
            string month = FromDateMonthToRussianLocal(date);
            return GetIncomeInThousand(month);
        }

        public int GetIncomeInThousand(string month)
        {
            if (_income.ContainsKey(month)) return (int)Math.Round(_income[month] / 100000.0);
            else return 0;
        }

        public Dictionary<string, int> NewClientsPerMonth()
        {
            Dictionary <string, int> clientsPerMonth = new Dictionary<string, int>();
            foreach (Client client in _clients)
            {
                string month = FromDateMonthToRussianLocal(client.registration_date);
                if (clientsPerMonth.ContainsKey(month)) clientsPerMonth[month] += 1;
                else clientsPerMonth[month] = 1;
            }

            return clientsPerMonth;
        }

        public int NewClientsInMonth(DateTime date)
        {
            Dictionary<string, int> clientsPerMonth = NewClientsPerMonth();
            string month = FromDateMonthToRussianLocal(date);
            if (clientsPerMonth.ContainsKey(month)) return clientsPerMonth[month];
            else return 0;
        }

        public Dictionary<string, double> AverageVisitsPerMonth()
        {
            Dictionary<string, List<int>> visitsPerMonth = new Dictionary<string, List<int>>();

            foreach (var client in _clients)
            {
                foreach (var visit in client.visitsPerMonth)
                {
                    string month = visit.Key;

                    if (!visitsPerMonth.ContainsKey(month))
                    {
                        visitsPerMonth[month] = new List<int>() { visit.Value };
                    }
                    else visitsPerMonth[month].Add(visit.Value);
                }
            }

            Dictionary<string, double> averageVisitsPerMonth = new Dictionary<string, double>();

            foreach (var kvp in visitsPerMonth)
            {
                string month = kvp.Key;
                List<int> visits = kvp.Value;

                double averageVisits = visits.Count > 0 ? visits.Average() : 0;
                averageVisitsPerMonth[month] = averageVisits;
            }

            return averageVisitsPerMonth;
        }


        public List<Client> GetClients() {  return _clients; }

        public List<Class> GetClasses() { return _groupClasses; }

        public List<Employee> GetEmployees() { return _employees; }

        private string FromDateMonthToRussianLocal(DateTime date) { return date.ToString("MMMM", new System.Globalization.CultureInfo("ru-RU")); }
    }
}
