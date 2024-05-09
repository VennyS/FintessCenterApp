namespace FitnessCenter
{
    partial class SelectAbonement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backFromAbonementsButton4 = new System.Windows.Forms.Button();
            this.Variant3AbonementButton3 = new System.Windows.Forms.Button();
            this.Variant2AbonementButton2 = new System.Windows.Forms.Button();
            this.Variant1AbonementButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptPlanButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backFromAbonementsButton4
            // 
            this.backFromAbonementsButton4.BackColor = System.Drawing.Color.Transparent;
            this.backFromAbonementsButton4.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromAbonementsButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromAbonementsButton4.FlatAppearance.BorderSize = 0;
            this.backFromAbonementsButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromAbonementsButton4.Location = new System.Drawing.Point(-3, 2);
            this.backFromAbonementsButton4.Name = "backFromAbonementsButton4";
            this.backFromAbonementsButton4.Size = new System.Drawing.Size(50, 33);
            this.backFromAbonementsButton4.TabIndex = 15;
            this.backFromAbonementsButton4.UseVisualStyleBackColor = false;
            this.backFromAbonementsButton4.Click += new System.EventHandler(this.backFromAbonementsButton4_Click);
            // 
            // Variant3AbonementButton3
            // 
            this.Variant3AbonementButton3.Location = new System.Drawing.Point(96, 85);
            this.Variant3AbonementButton3.Name = "Variant3AbonementButton3";
            this.Variant3AbonementButton3.Size = new System.Drawing.Size(222, 23);
            this.Variant3AbonementButton3.TabIndex = 14;
            this.Variant3AbonementButton3.Text = "16 занятий: 2800₽";
            this.Variant3AbonementButton3.UseVisualStyleBackColor = true;
            this.Variant3AbonementButton3.Click += new System.EventHandler(this.Variant3AbonementButton3_Click);
            // 
            // Variant2AbonementButton2
            // 
            this.Variant2AbonementButton2.Location = new System.Drawing.Point(96, 56);
            this.Variant2AbonementButton2.Name = "Variant2AbonementButton2";
            this.Variant2AbonementButton2.Size = new System.Drawing.Size(222, 23);
            this.Variant2AbonementButton2.TabIndex = 13;
            this.Variant2AbonementButton2.Text = "12 занятий: 2200₽";
            this.Variant2AbonementButton2.UseVisualStyleBackColor = true;
            this.Variant2AbonementButton2.Click += new System.EventHandler(this.Variant2AbonementButton2_Click);
            // 
            // Variant1AbonementButton1
            // 
            this.Variant1AbonementButton1.Location = new System.Drawing.Point(96, 27);
            this.Variant1AbonementButton1.Name = "Variant1AbonementButton1";
            this.Variant1AbonementButton1.Size = new System.Drawing.Size(222, 23);
            this.Variant1AbonementButton1.TabIndex = 12;
            this.Variant1AbonementButton1.Text = "8 занятий: 1600₽";
            this.Variant1AbonementButton1.UseVisualStyleBackColor = true;
            this.Variant1AbonementButton1.Click += new System.EventHandler(this.Variant1AbonementButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Абонементы";
            // 
            // acceptPlanButton4
            // 
            this.acceptPlanButton4.Location = new System.Drawing.Point(165, 114);
            this.acceptPlanButton4.Name = "acceptPlanButton4";
            this.acceptPlanButton4.Size = new System.Drawing.Size(85, 23);
            this.acceptPlanButton4.TabIndex = 17;
            this.acceptPlanButton4.Text = "подтвердить";
            this.acceptPlanButton4.UseVisualStyleBackColor = true;
            this.acceptPlanButton4.Visible = false;
            this.acceptPlanButton4.Click += new System.EventHandler(this.acceptPlanButton4_Click);
            // 
            // SelectAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(421, 149);
            this.Controls.Add(this.acceptPlanButton4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backFromAbonementsButton4);
            this.Controls.Add(this.Variant3AbonementButton3);
            this.Controls.Add(this.Variant2AbonementButton2);
            this.Controls.Add(this.Variant1AbonementButton1);
            this.Name = "SelectAbonement";
            this.Text = "SelectAbonement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backFromAbonementsButton4;
        private System.Windows.Forms.Button Variant3AbonementButton3;
        private System.Windows.Forms.Button Variant2AbonementButton2;
        private System.Windows.Forms.Button Variant1AbonementButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptPlanButton4;
    }
}