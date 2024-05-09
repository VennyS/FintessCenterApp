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
    public partial class SuccesForm : Form
    {
        public SuccesForm(string text)
        {
            InitializeComponent();
            succesLabel1.Text = text;

        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
