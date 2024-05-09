namespace FitnessCenter
{
    partial class SuccesForm
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
            this.exitButton1 = new System.Windows.Forms.Button();
            this.succesLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton1
            // 
            this.exitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.exitButton1.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Location = new System.Drawing.Point(3, 3);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(50, 33);
            this.exitButton1.TabIndex = 12;
            this.exitButton1.UseVisualStyleBackColor = false;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // succesLabel1
            // 
            this.succesLabel1.AutoSize = true;
            this.succesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succesLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.succesLabel1.Location = new System.Drawing.Point(59, 21);
            this.succesLabel1.Name = "succesLabel1";
            this.succesLabel1.Size = new System.Drawing.Size(176, 72);
            this.succesLabel1.TabIndex = 11;
            this.succesLabel1.Text = "Имя, успешно записана!\r\n31.04.24 18:00\r\nНаправление: силовая\r\n\r\n";
            // 
            // SuccesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(315, 92);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.succesLabel1);
            this.Name = "SuccesForm";
            this.Text = "Успешно!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton1;
        private System.Windows.Forms.Label succesLabel1;
    }
}