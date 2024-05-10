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

        /// Общие методы
        public MainForm()
        {
            InitializeComponent();

            manager = new Manager();
            _clients = manager.GetClients();
            _classes = manager.GetClasses();
            _employees = manager.GetEmployees();

            ShowGroupClasses();
            searchStaffResultListBox1.DataSource = _employees;
        }

        private void ShowOnlyTargetPanel(Control parentControl, string target)
        {
            foreach (Control control in parentControl.Controls)
            {
                if ((control is Panel) && (control.Name != target) && (control.Name != "splitter"))
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
        }

        private void ShowOnlyMainPanel(string target)
        {
            ShowOnlyTargetPanel(this, target);
        }

        private void ShowOnlyClientsPanel(string target)
        {
            ShowOnlyTargetPanel(clientsPanel2, target);
        }

        private void scheduleButton1_Click(object sender, EventArgs e)
        {
            _choosedClient = null;
            ShowOnlyMainPanel("schedulePanel1");
            searchStaffPanel1.Visible = true;
        }

        private void clientsButton2_Click(object sender, EventArgs e)
        {
            searchResultsClientsListBox1.DataSource = _clients;
            ShowOnlyMainPanel("clientsPanel2");
            ShowOnlyClientsPanel("showClientsPanel1");
        }

        private void staffButton3_Click(object sender, EventArgs e)
        {
            searchStaffResultListBox1.DataSource = _employees;
            ShowOnlyMainPanel("staffPanel3");
        }

        private void analysButton4_Click (object sender, EventArgs e)
        {
            ShowOnlyMainPanel("analysisPanel4");
            setUpAnalysis();
        }

        /// Групповые занятия
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            timesListBox2.DataSource = null;
            ShowGroupClasses();            
        }

        private void ShowGroupClasses(Client client = null)
        {
            dateScheduleLabel2.Text = monthCalendar1.SelectionStart.ToString("dd.MM.yyyy");
            // Получаем все классы, учитывая параметр client
            var allClasses = client != null ? _classes.Except(client.classes) : _classes;

            // Группируем классы по имени и выбираем первый класс из каждой группы
            var groupedClasses = allClasses.Where(@class => @class.isGroup && @class.dateTime.Date == monthCalendar1.SelectionStart)
                                           .GroupBy(@class => @class.name)
                                           .Select(group => group.First())
                                           .ToList();

            // Отображаем имена групп в typesOfClassesListBox1
            typesOfClassesListBox1.DataSource = groupedClasses;
        }

        private void typesOfClassesListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранную группу классов
            Class selectedClass = (Class)typesOfClassesListBox1.SelectedItem;

            // Фильтруем классы клиента, если он был передан
            var clientClasses = _choosedClient != null ? _choosedClient.classes.Where(c => c.name == selectedClass.name) : Enumerable.Empty<Class>();

            // Отображаем только те времена, которые не входят в классы клиента
            var times = _classes.Where(@class => @class.name == selectedClass.name && !clientClasses.Contains(@class))
                                .ToList();

            // Отображаем времена для выбранной группы в timesListBox2
            timesListBox2.DataSource = times;
        }

        private void signUpToGroupClassButton1_Click(object sender, EventArgs e)
        {
            Class @class = (Class) timesListBox2.SelectedItem;
            if (@class is null) return;

            if (_choosedClient is null)
            {
                schedulePanel1.Visible = false;
                clientsPanel2.Visible = true;
                searchResultsClientsListBox1.DataSource = _clients;
                _choosedClass = @class;
            }
            else
            {
                _choosedClient.appendClass(@class);
                @class.appendClient(_choosedClient);
                string text = $"{_choosedClient.full_name}, успешно записан(а)!\n{@class.dateTime.ToString("dd.MM.yy HH:mm")}\nнаправление: {@class.name}";
                SuccesForm succesForm = new SuccesForm(text);
                succesForm.ShowDialog();
                _choosedClient = null;
                _choosedClass = null;
            }
        }


        /// Клиенты
        private void chooseClientButton2_Click(object sender, EventArgs e)
        {
            _choosedClient = (Client)searchResultsClientsListBox1.SelectedItem;
            if (_choosedClient is null) return;

            if (_choosedClass is null && _choosedEmployee is null)
            {
                setUpInfoPanel(_choosedClient);
                ShowOnlyClientsPanel("clientInfoPanel3");
            }
            else
            {
                _choosedClient.appendClass(_choosedClass);
                _choosedClass.appendClient(_choosedClient);
                string variousText = _choosedEmployee is null ? $"направление: {_choosedClass.name}" : $"тренер: {_choosedEmployee.name}";
                string text = $"{_choosedClient.full_name}, успешно записан(а)!\n{_choosedClass.dateTime.ToString("dd.MM.yy HH:mm")}\n" + variousText;
                SuccesForm succesForm = new SuccesForm(text);
                succesForm.ShowDialog(this);
                _choosedClass = null;
                _choosedClient = null;
                _choosedEmployee = null;
            }
        }

        private void deleteClientButton3_Click(object sender, EventArgs e)
        {
            Client choosedClient = (Client)searchResultsClientsListBox1.SelectedItem;
            if (choosedClient is null) return;

            _clients.Remove(choosedClient);

            if (searchClientsTextBox.Text.Length == 0) searchResultsClientsListBox1.DataSource = _clients;
            else searchResultsClientsListBox1.DataSource = _clients.Where(client => client.full_name.Contains(searchClientsTextBox.Text)).ToList();
        }

        private void searchClientsTextBox_TextChanged(object sender, EventArgs e)
        {
            searchResultsClientsListBox1.DataSource = _clients.Where(client => client.full_name.Contains(searchClientsTextBox.Text)).ToList();
        }

        private void createClientsButton_Click(object sender, EventArgs e)
        {
            ShowOnlyClientsPanel("newClientPanel2");
        }

        private void backCreatingClientButton2_Click(object sender, EventArgs e)
        {
            ShowOnlyClientsPanel("showClientsPanel1");
        }

        private void newClientButton1_Click(object sender, EventArgs e)
        {
            if (fullNameTextBox1.Text.Length == 0 || weigthTextBox3.Text.Length == 0 || heigthTextBox4.Text.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (errorProvider1.GetError(fullNameTextBox1) != "" || errorProvider1.GetError(weigthTextBox3) != "" || errorProvider1.GetError(heigthTextBox4) != "")
            {
                MessageBox.Show("Пожалуйста, исправьте все ошибки ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowOnlyClientsPanel("showClientsPanel1");

            _clients.Add(new Client(fullNameTextBox1.Text, dateTimePicker1.Value, int.Parse(weigthTextBox3.Text), int.Parse(heigthTextBox4.Text)));

            if (searchClientsTextBox.Text.Length == 0) searchResultsClientsListBox1.DataSource = _clients;
            else searchResultsClientsListBox1.DataSource = _clients.Where(client => client.full_name.Contains(searchClientsTextBox.Text)).ToList();

        }

        private void setUpInfoPanel(Client client)
        {
            _choosedClient = client;
            clientNameLabel1.Text = _choosedClient.full_name;
            birthDateLabel2.Text = $"дата рождения: {_choosedClient.date_of_birth.Date.ToString("dd.MM.yyyy")}";
            weightLabel3.Text = $"вес: {_choosedClient.weight_kg}";
            heightLabel4.Text = $"рост: {_choosedClient.height_cm}";
            classesRestLabel5.Text = $"количество оставшихся занятий: {_choosedClient.remaining_visits}";

            Series series = chart1.Series.FindByName("Посещения");
            series.Points.Clear();

            foreach (var visit in client.visitsPerMonth)
            {
                series.Points.AddXY(visit.Key, visit.Value);
            }
        }

        private void backFromClientInfoButton4_Click(object sender, EventArgs e)
        {
            ShowOnlyClientsPanel("showClientsPanel1");
        }

        private void addClasseButton3_Click(object sender, EventArgs e)
        {
            SelectAbonement selectAbonement = new SelectAbonement();
            selectAbonement.ShowDialog();

            if (selectAbonement.isPlanChoosed)
            {
                _choosedClient.addAbonement(selectAbonement.selectedPlan);
                setUpInfoPanel(_choosedClient);
            }
        }

        private void visitHistoryButton1_Click(object sender, EventArgs e)
        {
            ShowOnlyClientsPanel("visitHistoryPanel6");
            setUpVisitHistoryPanel();
        }

        private void setUpVisitHistoryPanel()
        {
            clientNameLabel2.Text = _choosedClient.full_name;
            visitsShowListBox1.DataSource = _choosedClient.classes;
        }

        private void backFromVisitHistoryButton1_Click(object sender, EventArgs e)
        {
            ShowOnlyClientsPanel("clientInfoPanel3");
        }

        private void signUpButton2_Click(object sender, EventArgs e)
        {
            SelectClassTypeForm selectClassTypeForm = new SelectClassTypeForm();
            selectClassTypeForm.ShowDialog();
            
            if (selectClassTypeForm.classType == ClassType.Individual)
            {
                ShowOnlyMainPanel("staffPanel3");
                searchStaffResultListBox1.DataSource = _employees;
            }
            else if (selectClassTypeForm.classType == ClassType.Group)
            {
                ShowOnlyMainPanel("schedulePanel1");
                ShowGroupClasses(_choosedClient);
            }
        }


        /// Индивидуальные занятия
        private void setUpIndividualClasses()
        {
            invidualClassesLabel2.Text = monthCalendar2.SelectionStart.ToString("dd.MM.yy");
            employeeInfoButton1.Text = $"{_choosedEmployee.name}\n{_choosedEmployee.degree}";
            individualClassesListBox2.DataSource = _choosedEmployee.classes.Where(@class => @class.dateTime.Date == monthCalendar2.SelectionStart).ToList();
        }

        private void selectEmployeeButton1_Click(object sender, EventArgs e)
        {
            _choosedEmployee = (Employee)searchStaffResultListBox1.SelectedItem;

            if (_choosedEmployee is null) return;

            searchStaffPanel1.Visible = false;
            individualClassesPanel2.Visible = true;
            setUpIndividualClasses();
        }

        private void selectInvidialClassButton2_Click(object sender, EventArgs e)
        {
            Class @class = (Class)individualClassesListBox2.SelectedItem;
            if (@class is null) return;

            if (_choosedClient is null)
            {
                _choosedClass = @class;
                ShowOnlyMainPanel("clientsPanel2");
            }
            else
            {
                _choosedClient.appendClass(@class);
                @class.appendClient(_choosedClient);
                _choosedClass = null;
                _choosedClient = null;
                _choosedEmployee = null;
                string text = $"{_choosedClient.full_name}, успешно записан(а)!\n{@class.dateTime.ToString("dd.MM.yy HH:mm")}\n" +
                    $"тренер: {_choosedEmployee.name}";
                this.ShowDialog(new SuccesForm(text));
            }
        }

        private void employeeInfoButton1_Click(object sender, EventArgs e)
        {
            _choosedEmployee = null;
            individualClassesPanel2.Visible = false;
            searchStaffPanel1.Visible = true;
        }

        private void searchStaffTextBox1_TextChanged(object sender, EventArgs e)
        {
            string query = searchStaffTextBox1.Text;
            searchStaffResultListBox1.DataSource = query.Length > 0 ? _employees.Where(employee => employee.name.ToLower().Contains(query.ToLower())).ToList() : _employees;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            setUpIndividualClasses();
        }

        /// Анализ

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

            chart2.Series.Add(incomePerMonth);
            chart2.Series.Add(newClientsPerMonth);
            chart2.Series.Add(averageVisitsPerMonth);
            
        }

        private void fullNameTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text) && newClientPanel2.Visible)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Это поле не может быть пустым.");
            }
            else
            {
                errorProvider1.SetError(textBox, ""); // Очистка сообщения об ошибке, если валидация успешна
            }
        }

        private void Integers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int result;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Это поле не может быть пустым.");
            }
            else if (!int.TryParse(textBox.Text, out result))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Пожалуйста, введите целое число.");
            }
            else
            {
                errorProvider1.SetError(textBox, ""); // Очистка сообщения об ошибке, если валидация успешна
            }
        }

        private void newClientPanel2_VisibleChanged(object sender, EventArgs e)
        {
            fullNameTextBox1.Text = "";
            weigthTextBox3.Text = "";
            heigthTextBox4.Text = "";
            errorProvider1.Clear();
        }

        private void deleteVisitButton1_Click(object sender, EventArgs e)
        {
            Class @class = (Class)visitsShowListBox1.SelectedItem;
            if (@class == null) return;

            visitsShowListBox1.DataSource = null;
            _choosedClient.classes.Remove(@class);
            visitsShowListBox1.DataSource = _choosedClient.classes;
        }
    }
}
