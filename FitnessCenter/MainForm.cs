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
                    Button btn = new Button();
                    btn.Text = client.full_name;
                    btn.Size = new Size(330, btn.Size.Height);
                    btn.Click += (sender, e) => ClientButton_Click(client);
                    btn.Location = new Point(0, topMargin); // каждая кнопка размещается на новой строке
                    searchResultsClientsPanel1.Controls.Add(btn);

                    // Увеличиваем отступ сверху для следующей кнопки
                    topMargin += btn.Height + 5; // добавляем высоту кнопки и небольшой отступ
                    count++;
                }               
            }

            if (count == 0) notFoundClientsLabel1.Visible = true;
            else notFoundClientsLabel1.Visible = false;
            return count;
        }

        private void ClientButton_Click(Client client)
        {
            MessageBox.Show($"Нажата кнопка для клиента: {client.full_name}");
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
    }
}
