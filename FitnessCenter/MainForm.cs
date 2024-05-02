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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
