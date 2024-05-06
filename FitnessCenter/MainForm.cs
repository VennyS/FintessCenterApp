﻿using FitnessCenter.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitnessCenter
{
    public partial class MainForm : Form
    {
        private Manager manager;
        private List<Client> _clients;
        private List<Class> _classes;
        private List<Employee> _employees;
        private Client _choosedClient = null;
        private Class _choosedClass = null;
        private Employee _choosedEmployee = null;
        private int _choosedPlan;
        public MainForm()
        {
            InitializeComponent();

            manager = new Manager();

            _clients = manager.GetClients();
            _classes = manager.GetClasses();
            _employees = manager.GetEmployees();

            ShowGroupClasses();
        }

        private void ShowGroupClasses(Client client = null)
        {
            availableSchedulePanel1.Controls.Clear();
            int topMargin = 0;

            foreach (var group in _classes.GroupBy(c => c.name))
            {
                Class firstClass = group.First();
                DateTime classDate = firstClass.dateTime.Date;

                if (classDate == monthCalendar1.SelectionStart && firstClass.isGroup)
                {
                    // Создаем кнопку для имени класса
                    Button btnName = new Button();
                    btnName.Text = group.Key;
                    btnName.Size = new Size(100, 22);
                    btnName.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    availableSchedulePanel1.Controls.Add(btnName);

                    int leftMargin = btnName.Width + 5;

                    // Ищем все уникальные времена для данной группы классов
                    foreach (Class @class in group)
                    {
                        Button btnTime = new Button();
                        btnTime.Text = @class.dateTime.ToString("HH:mm"); // Используем дату класса для вывода времени
                        btnTime.Size = new Size(50, 22);
                        btnTime.Click += (sender, e) => showUpSuccesClassRegistration(@class);
                        btnTime.Location = new Point(leftMargin, topMargin);
                        leftMargin += btnTime.Width + 5;
                        availableSchedulePanel1.Controls.Add(btnTime);
                        if ((@class.dateTime.Date < DateTime.Now) || (!(client is null) && (client.classes.Contains(@class))))
                        {
                            btnTime.Enabled = false;
                        }
                    }

                    topMargin += btnName.Height + 5;
                }
                dateScheduleLabel2.Text = monthCalendar1.SelectionStart.ToString("dd.MM.yyyy");
            }
        }

        private void showUpSuccesClassRegistration(Class @class)
        {
            if (_choosedClient is null)
            {
                schedulePanel1.Visible = false;
                clientsPanel2.Visible = true;
                ShowClientsContains();
                _choosedClass = @class;
            }
            else
            {
                succesRegistrationSchedulePanel2.Visible = true;
                _choosedClient.appendClass(@class);
                @class.appendClient(_choosedClient);
                succesLabel1.Text = $"{_choosedClient.full_name}, успешно записан(а)!\n{@class.dateTime.ToString("dd.MM.yy HH:mm")}\nнаправление:{@class.name}";
                _choosedClient = null;
                _choosedClass = null;
            }            
        }

        private bool ShowClientsContains(string text = "")
        {
            // Очищаем все предыдущие кнопки
            var buttons = searchResultsClientsPanel1.Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons) searchResultsClientsPanel1.Controls.Remove(button);

            bool anyItemContains = false;
            int topMargin = 0; // отступ сверху для первой кнопки

            foreach (Client client in _clients)
            {
                if (client.full_name.ToLower().Contains(text.ToLower()))
                {
                    Button btnClient = new Button();
                    btnClient.Text = client.full_name;
                    btnClient.Size = new Size(330, 22);
                    btnClient.Click += (sender, e) => ClientButton_Click(client);
                    btnClient.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    Button deleteClient = new Button();
                    deleteClient.Text = "Удалить";
                    deleteClient.Size = new Size(94, 22);
                    deleteClient.Click += (sender, e) => DeleteClientButton_Click(client, text);
                    deleteClient.Location = new Point(btnClient.Width+11, topMargin); // каждая кнопка размещается на новой строке
                    searchResultsClientsPanel1.Controls.Add(btnClient);
                    searchResultsClientsPanel1.Controls.Add(deleteClient);

                    // Увеличиваем отступ сверху для следующей кнопки
                    topMargin += btnClient.Height + 5; // добавляем высоту кнопки и небольшой отступ
                    anyItemContains = true;
                }               
            }

            if (!anyItemContains) notFoundClientsLabel1.Visible = true;
            else notFoundClientsLabel1.Visible = false;
            return anyItemContains;
        }

        private void ClientButton_Click(Client client)
        {
            if (_choosedClass is null && _choosedEmployee is null)
            {
                showClientsPanel1.Visible = false;
                setUpInfoPanel(client);
                clientInfoPanel3.Visible = true;
            }
            else
            {
                succesRegistrationSchedulePanel2.Visible = true;
                client.appendClass(_choosedClass);
                _choosedClass.appendClient(client);

                string variousText = _choosedEmployee is null ? $"направление :{_choosedClass.name}" : $"тренер {_choosedEmployee.Name}";
                succesLabel1.Text = $"{client.full_name}, успешно записан(а)!\n{_choosedClass.dateTime.ToString("dd.MM.yy HH:mm")}\n" + variousText;
                _choosedClass = null;
                _choosedClient = null;
                _choosedEmployee = null;
            }
        }

        private void DeleteClientButton_Click(Client choosedClient, string text)
        {
            
            foreach (Client client in _clients)
            {
                if (choosedClient == client)
                {
                    _clients.Remove(client);
                    ShowClientsContains(text);
                    return;
                }
            }
        }

        private void showOnlyMainPanel(string target)
        {
            foreach (Control control in this.Controls)
            {
                if ((control is Panel) && (control.Name != target) && (control.Name != "splitter")) control.Visible = false;
                else control.Visible = true;
            }
        }

        private void showOnlyClientsPanel(string target)
        {

        }

        private void setUpStaffPanel(string text = "")
        {
            var buttons = searchResultsStaffPanel1.Controls.OfType<Button>().ToArray();
            foreach (var button in buttons) { searchResultsStaffPanel1.Controls.Remove(button); }

            int topMargin = 0; // отступ сверху для первой кнопки
            bool anyItemContains = false;

            foreach (Employee employee in _employees)
            {
                if ((employee.Name.ToLower().Contains(text.ToLower())) || (employee.degree.ToLower().Contains(text.ToLower())))
                {
                    Button btnClass = new Button();
                    btnClass.Text = $"{employee.Name}\n{employee.degree}";
                    btnClass.Size = new Size(330, 35);
                    btnClass.Click += (sender, e) => employeeButtonClick(employee);
                    btnClass.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    Button btnDeleteClass = new Button();
                    btnDeleteClass.Text = "Удалить";
                    btnDeleteClass.Size = new Size(94, 22);
                    /*btnDeleteClass.Click += (sender, e) => deleteClass(@class);*/
                    btnDeleteClass.Location = new Point(btnClass.Width + 11, topMargin); // каждая кнопка размещается на новой строке
                    searchResultsStaffPanel1.Controls.Add(btnClass);
                    searchResultsStaffPanel1.Controls.Add(btnDeleteClass);

                    topMargin += btnClass.Height + 5;
                    anyItemContains = true;
                }                
            }
            if (!anyItemContains) notFoundStaffLabel1.Visible = true;
            else notFoundStaffLabel1.Visible = false;
        }

        private void showIndividualClasses()
        {
            var buttons = individualClassesPanel1.Controls.OfType<Button>().ToArray();
            foreach (var button in buttons) { individualClassesPanel1.Controls.Remove(button); }

            invidualClassesLabel2.Text = monthCalendar2.SelectionStart.ToString("dd.MM.yy");

            int topMargin = 0; // отступ сверху для первой кнопки
            bool anyItemContains = false;

            foreach (Class @class in _choosedEmployee.classes)
            {
                if (@class.dateTime.Date == monthCalendar2.SelectionStart)
                {
                    Button btnClass = new Button();
                    btnClass.Text = $"{@class.dateTime.ToString("HH:mm")}";
                    btnClass.Size = new Size(100, 22);
                    btnClass.Click += (sender, e) => individualClassButtonClick(@class);
                    btnClass.Location = new Point((individualClassesPanel1.Width-btnClass.Width)/2, topMargin); // каждая кнопка размещается на новой строке
                    /*Button btnDeleteClass = new Button();
                    btnDeleteClass.Text = "Удалить";
                    btnDeleteClass.Size = new Size(94, 22);
                    *//*btnDeleteClass.Click += (sender, e) => deleteClass(@class);*//*
                    btnDeleteClass.Location = new Point(btnClass.Width + 11, topMargin); // каждая кнопка размещается на новой строке*/
                    individualClassesPanel1.Controls.Add(btnClass);
                    /*searchResultsStaffPanel1.Controls.Add(btnDeleteClass);*/

                    topMargin += btnClass.Height + 5;
                    anyItemContains = true;
                }
            }
            if (!anyItemContains) notFoundIndividualClassesLabel3.Visible = true;
            else notFoundIndividualClassesLabel3.Visible = false;
        }
        private void setUpIndividualClasses()
        {
            employeeInfoButton1.Text = $"{_choosedEmployee.Name}\n{_choosedEmployee.degree}";
            showIndividualClasses();
        }

        private void individualClassButtonClick(Class @class)
        {
            if (_choosedClient is null)
            {
                _choosedClass = @class;
                showOnlyMainPanel("clientsPanel2");
            }
            else
            {
                succesRegistrationSchedulePanel2.Visible = true;
                _choosedClient.appendClass(@class);
                @class.appendClient(_choosedClient);

                succesLabel1.Text = $"{_choosedClient.full_name}, успешно записан(а)!\n{@class.dateTime.ToString("dd.MM.yy HH:mm")}\n" +
                    $"тренер {_choosedEmployee.Name}";
                _choosedClass = null;
                _choosedClient = null;
                _choosedEmployee = null;
            }
        }

        private void employeeButtonClick(Employee employee)
        {
            _choosedEmployee = employee;
            searchStaffPanel1.Visible = false;
            individualClassesPanel2.Visible = true;
            setUpIndividualClasses();
        }

        private void scheduleButton1_Click(object sender, EventArgs e)
        {
            _choosedClient = null;
            showOnlyMainPanel("schedulePanel1");
            searchStaffPanel1.Visible = true;
        }

        private void clientsButton2_Click(object sender, EventArgs e)
        {
            ShowClientsContains();
            showOnlyMainPanel("clientsPanel2");
        }

        private void staffButton3_Click(object sender, EventArgs e)
        {
            setUpStaffPanel();
            showOnlyMainPanel("staffPanel3");
        }

        // TODO
        private void analysButton4_Click(object sender, EventArgs e)
        {
            showOnlyMainPanel("analysisPanel4");
            setUpAnalysis();

        }

        private void setUpAnalysis()
        {
            chart2.Series.Clear();

            clientCountLabel2.Text = $"Количество клиентов: {manager.NewClientsInMonth(DateTime.Now)}";
            incomeLabel3.Text = $"Прибыль в сотнях тысяч рублей: {manager.GetIncomeInThousand(DateTime.Now)}";

            Series newClientsPerMonth = new Series();
            newClientsPerMonth.Name = "Новые клиенты";
            
            foreach (var pair in manager.NewClientsPerMonth()) { newClientsPerMonth.Points.AddXY(pair.Key, pair.Value); }

            Series averageVisitsPerMonth = new Series();
            
            averageVisitsPerMonth.Name = "Среднее количество посещений";
            foreach (var pair in manager.AverageVisitsPerMonth()) { averageVisitsPerMonth.Points.AddXY(pair.Key, pair.Value); }

            Series incomePerMonth = new Series();
 
            incomePerMonth.Name = "Прибыль в сотнях тысяч рублей";
            foreach (var pair in manager.GetIncomeInThousand())
            {    
                incomePerMonth.Points.AddXY(pair.Key, pair.Value);
            }

        chart2.Series.Add(newClientsPerMonth);
            chart2.Series.Add(averageVisitsPerMonth);
            chart2.Series.Add(incomePerMonth);
        }

        private void searchClientsTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowClientsContains(searchClientsTextBox.Text);
        }

        private void createClientsButton_Click(object sender, EventArgs e)
        {
            showClientsPanel1.Visible = false;
            clientInfoPanel3.Visible = false;
            newClientPanel2.Visible = true;
            searchClientsTextBox.Text = "";
        }

        private void backCreatingClientButton2_Click(object sender, EventArgs e)
        {
            showClientsPanel1.Visible = true;
            clientInfoPanel3.Visible = false;
            newClientPanel2.Visible = false;
        }

        private void newClientButton1_Click(object sender, EventArgs e)
        {
            showClientsPanel1.Visible = true;
            clientInfoPanel3.Visible = false;
            newClientPanel2.Visible = false;

            _clients.Add(new Client(fullNameTextBox1.Text, dateTimePicker1.Value, int.Parse(weigthTextBox3.Text), int.Parse(heigthTextBox4.Text)));
            ShowClientsContains();
        }

        private void setUpInfoPanel(Client client)
        {
            _choosedClient = client;
            clientNameLabel1.Text = _choosedClient.full_name;
            birthDateLabel2.Text = _choosedClient.date_of_birth.Date.ToString("dd.MM.yyyy");
            weightLabel3.Text = $"вес: {_choosedClient.weight_kg}";
            heightLabel4.Text = $"рост: {_choosedClient.height_cm}";
            classesRestLabel5.Text = $"осталось занятий: {_choosedClient.remaining_visits}";

            Series series = chart1.Series.FindByName("Посещения");
            series.Points.Clear();

            foreach (var visit in client.visitsPerMonth)
            {
                series.Points.AddXY(visit.Key, visit.Value);
            }
        }

        private void backFromClientInfoButton4_Click(object sender, EventArgs e)
        {
            clientInfoPanel3.Visible = false;
            showClientsPanel1.Visible = true;
        }

        private void addClasseButton3_Click(object sender, EventArgs e)
        {
            abonementsPanel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abonementsPanel4.Visible = false;
        }

        private void Variant1AbonementButton1_Click(object sender, EventArgs e)
        {
            _choosedPlan = 8;
            abonementsPanel4.Visible = false;
            choosedPlanPanel5.Visible = true;
            choosedPlanButton1.Text = Variant1AbonementButton1.Text;
        }

        private void Variant2AbonementButton2_Click(object sender, EventArgs e)
        {
            _choosedPlan = 12;
            abonementsPanel4.Visible = false;
            choosedPlanPanel5.Visible = true;
            choosedPlanButton1.Text = Variant2AbonementButton2.Text;
        }

        private void Variant3AbonementButton3_Click(object sender, EventArgs e)
        {
            _choosedPlan = 16;
            abonementsPanel4.Visible = false;
            choosedPlanPanel5.Visible = true;
            choosedPlanButton1.Text = Variant3AbonementButton3.Text;
        }

        private void acceptPlanButton3_Click(object sender, EventArgs e)
        {
            _choosedClient.addAbonement(_choosedPlan);
            choosedPlanPanel5.Visible = false;
            setUpInfoPanel(_choosedClient);
        }

        private void backFromChosedPlanButton3_Click(object sender, EventArgs e)
        {
            choosedPlanPanel5.Visible = false;
            abonementsPanel4.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowGroupClasses(_choosedClient);
        }

        private void visitHistoryButton1_Click(object sender, EventArgs e)
        {
            clientInfoPanel3.Visible = false;
            visitHistoryPanel6.Visible = true;
            setUpVisitHistoryPanel();
        }

        private void setUpVisitHistoryPanel()
        {
            var buttons = visitsShowPanel1.Controls.OfType<Button>().ToArray();
            foreach (var button in buttons) { visitsShowPanel1.Controls.Remove(button); }

            clientNameLabel2.Text = _choosedClient.full_name;
            int topMargin = 0; // отступ сверху для первой кнопки
            bool anyItemContains = false;

            foreach (Class @class in _choosedClient.classes)
            {
                Button btnClass = new Button();
                btnClass.Text = @class.dateTime.ToString("dd.MM.yyyy HH:mm") + $" направление: {@class.name.ToLower()}";
                btnClass.Size = new Size(330, 22);
                /*btnClass.Click += (sender, e) => ClientButton_Click(client);*/
                btnClass.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                Button btnDeleteClass = new Button();
                btnDeleteClass.Text = "Удалить";
                btnDeleteClass.Size = new Size(94, 22);
                btnDeleteClass.Click += (sender, e) => deleteClass(@class);
                btnDeleteClass.Location = new Point(btnClass.Width + 11, topMargin); // каждая кнопка размещается на новой строке
                visitsShowPanel1.Controls.Add(btnClass);
                visitsShowPanel1.Controls.Add(btnDeleteClass);

                topMargin += btnClass.Height + 5;
                anyItemContains = true;
            }
            if (!anyItemContains) notFoundVisitsLabel1.Visible = true;
            else notFoundVisitsLabel1.Visible = false;
        }

        private void deleteClass(Class @class)
        {
            _choosedClient.removeClass(@class);
            setUpVisitHistoryPanel();
        }

        private void backFromVisitHistoryButton1_Click(object sender, EventArgs e)
        {
            clientInfoPanel3.Visible = true;
            visitHistoryPanel6.Visible = false;
        }

        private void signUpButton2_Click(object sender, EventArgs e)
        {
            selectClassTypePanel7.Visible = true;
        }

        private void backFromSuccesPanelButton1_Click(object sender, EventArgs e)
        {
            succesRegistrationSchedulePanel2.Visible = false;
        }

        private void selectGroupClassButton1_Click(object sender, EventArgs e)
        {
            clientsPanel2.Visible = false;
            selectClassTypePanel7.Visible = false;
            schedulePanel1.Visible = true;
            ShowGroupClasses(_choosedClient);
            clientInfoPanel3.Visible = false;
            showClientsPanel1.Visible = true;
        }

        private void searchStaffTextBox1_TextChanged(object sender, EventArgs e)
        {
            setUpStaffPanel(searchStaffTextBox1.Text);
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            setUpIndividualClasses();
        }

        private void employeeInfoButton1_Click(object sender, EventArgs e)
        {
            _choosedEmployee = null;
            individualClassesPanel2.Visible = false;
            searchStaffPanel1.Visible = true;
        }

        private void selectPersonalClassButton2_Click(object sender, EventArgs e)
        {
            showOnlyMainPanel("staffPanel3");
            selectClassTypePanel7.Visible = false;
            setUpStaffPanel();
        }
    }
}
