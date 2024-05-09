using System;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class SelectAbonement : Form
    {
        public int selectedPlan { get; private set; }
        public bool isPlanChoosed {  get; set; }
        public SelectAbonement()
        {
            InitializeComponent();
        }

        private void Variant1AbonementButton1_Click(object sender, EventArgs e)
        {
            selectedPlan = 8;
            Variant2AbonementButton2.Enabled = false;
            Variant3AbonementButton3.Enabled = false;
            acceptPlanButton4.Visible = true;
            isPlanChoosed = true;
        }

        private void Variant2AbonementButton2_Click(object sender, EventArgs e)
        {
            selectedPlan = 12;
            Variant1AbonementButton1.Enabled = false;
            Variant3AbonementButton3.Enabled = false;
            acceptPlanButton4.Visible = true;
            isPlanChoosed = true;
        }

        private void Variant3AbonementButton3_Click(object sender, EventArgs e)
        {
            Variant1AbonementButton1.Enabled = false;
            Variant2AbonementButton2.Enabled = false;
            selectedPlan = 16;
            acceptPlanButton4.Visible = true;
            isPlanChoosed = true;
        }

        private void backFromAbonementsButton4_Click(object sender, EventArgs e)
        {
            if (isPlanChoosed)
            {
                Variant1AbonementButton1.Enabled = true;
                Variant2AbonementButton2.Enabled = true;
                Variant3AbonementButton3.Enabled = true;
                acceptPlanButton4.Visible = false;
                isPlanChoosed = false;
            }
            else
            {
                this.Close();
            }
        }

        private void acceptPlanButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
