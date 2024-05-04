﻿using FitnessCenter.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class MainForm : Form
    {
        private List<Client> _clients;
        private List<Class> _classes;
        private Client _choosedClient;
        private int _choosedPlan;
        public MainForm()
        {
            InitializeComponent();

            Manager manager = new Manager();

            _clients = manager.GetClients();
            _classes = manager.GetClasses();

            ShowGroupClasses();
        }

        private void ShowGroupClasses()
        {
            availableSchedulePanel1.Controls.Clear();
            int topMargin = 0;

            foreach (var group in _classes.GroupBy(c => c.name))
            {
                Class firstClass = group.First();
                DateTime classDate = firstClass.dateTime.Date;

                if (classDate == monthCalendar1.SelectionStart)
                {
                    // Создаем кнопку для имени класса
                    Button btnName = new Button();
                    btnName.Text = group.Key;
                    btnName.Size = new Size(100, 22);
                    btnName.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    availableSchedulePanel1.Controls.Add(btnName);

                    int leftMargin = btnName.Width + 5;

                    // Ищем все уникальные времена для данной группы классов
                    foreach (Class classTime in group)
                    {
                        Button btnTime = new Button();
                        btnTime.Text = classTime.dateTime.ToString("HH:mm"); // Используем дату класса для вывода времени
                        btnTime.Size = new Size(50, 22);
                        btnTime.Location = new Point(leftMargin, topMargin);
                        leftMargin += btnTime.Width + 5;
                        availableSchedulePanel1.Controls.Add(btnTime);
                    }

                    topMargin += btnName.Height + 5;
                }
            }

            /*foreach (Class @class in _classes)
            {
                // Проверяем, что класс проходит в выбранный день
                if (@class.dateTime.Date == monthCalendar1.SelectionStart)
                {
                    Button btnName = new Button();
                    btnName.Text = @class.name;
                    btnName.Size = new Size(100, 22);
                    btnName.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    availableSchedulePanel1.Controls.Add(btnName);

                    int leftMargin = btnName.Width + 5;

                    // Создаем список для хранения уникальных временных кнопок
                    List<string> uniqueClasses = new List<string>();

                    // Ищем все уникальные времена для класса с таким же именем и датой
                    foreach (Class classTime in _classes.Where(c => c.name == @class.name && c.dateTime.Date == @class.dateTime.Date))
                    {
                        // Проверяем, не добавлено ли уже такое время
                        if (!uniqueClasses.Contains(classTime.name))
                        {
                            Button btnTime = new Button();
                            btnTime.Text = classTime.dateTime.ToString("HH:mm"); // Используем дату класса для вывода времени
                            btnTime.Size = new Size(50, 22);
                            btnTime.Location = new Point(leftMargin, topMargin);
                            leftMargin += btnTime.Width + 5;
                            availableSchedulePanel1.Controls.Add(btnTime);

                            // Добавляем время в список уникальных времен
                            uniqueClasses.Add(classTime.name);
                        }
                    }

                    topMargin += btnName.Height + 5;
                }
            }*/
        }

        private bool ShowClientsContains(string text = "")
        {
            // Очищаем все предыдущие кнопки
            var buttons = searchResultsClientsPanel1.Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons) searchResultsClientsPanel1.Controls.Remove(button);

            bool anyItemContains = false; // 
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
            showClientsPanel1.Visible = false;
            setUpInfoPanel(client);
            clientInfoPanel3.Visible = true;
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

        private void showOnlyPanel(string target)
        {
            foreach (Control control in this.Controls)
            {
                if ((control is Panel) && (control.Name != target) && (control.Name != "splitter")) control.Visible = false;
                else control.Visible = true;
            }
        }

        private void scheduleButton1_Click(object sender, EventArgs e)
        {
            showOnlyPanel("schedulePanel1");
        }

        private void clientsButton2_Click(object sender, EventArgs e)
        {
            ShowClientsContains();
            showOnlyPanel("clientsPanel2");
        }

        private void staffButton3_Click(object sender, EventArgs e)
        {
            showOnlyPanel("staffPanel3");
        }

        // TODO
        private void analysButton4_Click(object sender, EventArgs e)
        {
            ;
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
            birthDateLabel2.Text = _choosedClient.date_of_birth.ToString();
            weightLabel3.Text = _choosedClient.weight_kg.ToString();
            heightLabel4.Text = _choosedClient.height_cm.ToString();
            classesRestLabel5.Text = "осталось занятий: " + _choosedClient.remaining_visits.ToString();
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
            ShowGroupClasses();
        }
    }
}
