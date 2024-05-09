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
    public enum ClassType
    {
        Group,
        Individual,
        None
    }

    public partial class SelectClassTypeForm : Form
    {
        public ClassType classType { get; private set; }

        public SelectClassTypeForm()
        {
            InitializeComponent();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            classType = ClassType.None;
            this.Close();
        }

        private void selectGroupClassButton1_Click(object sender, EventArgs e)
        {
            classType = ClassType.Group;
            this.Close();
        }

        private void selectPersonalClassButton2_Click(object sender, EventArgs e)
        {
            classType = ClassType.Individual;
            this.Close();
        }
    }
}
