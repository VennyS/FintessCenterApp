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
        public MainForm()
        {
            InitializeComponent();

            Manager manager = new Manager();
            _clients = manager.GetClients();
            ShowClientsContains();
        }

        private int ShowClientsContains(string text = "")
        {
            // Очищаем все предыдущие кнопки
            var buttons = searchResultsClientsPanel1.Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons) searchResultsClientsPanel1.Controls.Remove(button);

            int count = 0;
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
                    deleteClient.Click += (sender, e) => ClientButton_Click(client);
                    deleteClient.Location = new Point(btnClient.Width+11, topMargin); // каждая кнопка размещается на новой строке
                    searchResultsClientsPanel1.Controls.Add(btnClient);
                    searchResultsClientsPanel1.Controls.Add(deleteClient);

                    // Увеличиваем отступ сверху для следующей кнопки
                    topMargin += btnClient.Height + 5; // добавляем высоту кнопки и небольшой отступ
                    count++;
                }               
            }

            if (count == 0) notFoundClientsLabel1.Visible = true;
            else notFoundClientsLabel1.Visible = false;
            return count;
        }

        private void ClientButton_Click(Client client)
        {
            showClientsPanel1.Visible = false;
            setUpInfoPanel(client);
            clientInfoPanel3.Visible = true;
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

        // TODO: реализовать добавление дня рождения через календарь
        private void newClientButton1_Click(object sender, EventArgs e)
        {
            showClientsPanel1.Visible = true;
            clientInfoPanel3.Visible = false;
            newClientPanel2.Visible = false;

            _clients.Add(new Client(fullNameTextBox1.Text, new DateTime(), int.Parse(weigthTextBox3.Text), int.Parse(heigthTextBox4.Text)));
            ShowClientsContains();
        }

        private void setUpInfoPanel(Client client)
        {
            clientNameLabel1.Text = client.full_name;
            birthDateLabel2.Text = client.date_of_birth.ToString();
            weightLabel3.Text = client.weight_kg.ToString();
            heightLabel4.Text = client.height_cm.ToString();
            classesRestLabel5.Text = client.remaining_visits.ToString();
        }
    }
}
