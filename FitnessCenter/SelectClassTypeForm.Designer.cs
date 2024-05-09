namespace FitnessCenter
{
    partial class SelectClassTypeForm
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
            this.selectPersonalClassButton2 = new System.Windows.Forms.Button();
            this.selectGroupClassButton1 = new System.Windows.Forms.Button();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.classTypeLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectPersonalClassButton2
            // 
            this.selectPersonalClassButton2.Location = new System.Drawing.Point(228, 38);
            this.selectPersonalClassButton2.Name = "selectPersonalClassButton2";
            this.selectPersonalClassButton2.Size = new System.Drawing.Size(131, 28);
            this.selectPersonalClassButton2.TabIndex = 16;
            this.selectPersonalClassButton2.Text = "Индивидуальное";
            this.selectPersonalClassButton2.UseVisualStyleBackColor = true;
            this.selectPersonalClassButton2.Click += new System.EventHandler(this.selectPersonalClassButton2_Click);
            // 
            // selectGroupClassButton1
            // 
            this.selectGroupClassButton1.Location = new System.Drawing.Point(67, 38);
            this.selectGroupClassButton1.Name = "selectGroupClassButton1";
            this.selectGroupClassButton1.Size = new System.Drawing.Size(130, 28);
            this.selectGroupClassButton1.TabIndex = 15;
            this.selectGroupClassButton1.Text = "Групповое";
            this.selectGroupClassButton1.UseVisualStyleBackColor = true;
            this.selectGroupClassButton1.Click += new System.EventHandler(this.selectGroupClassButton1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.exitButton1.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Location = new System.Drawing.Point(3, -2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(50, 33);
            this.exitButton1.TabIndex = 14;
            this.exitButton1.UseVisualStyleBackColor = false;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // classTypeLabel1
            // 
            this.classTypeLabel1.AutoSize = true;
            this.classTypeLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.classTypeLabel1.Location = new System.Drawing.Point(154, 8);
            this.classTypeLabel1.Name = "classTypeLabel1";
            this.classTypeLabel1.Size = new System.Drawing.Size(114, 13);
            this.classTypeLabel1.TabIndex = 13;
            this.classTypeLabel1.Text = "Записать на занятие";
            // 
            // SelectClassTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(421, 85);
            this.Controls.Add(this.selectPersonalClassButton2);
            this.Controls.Add(this.selectGroupClassButton1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.classTypeLabel1);
            this.Name = "SelectClassTypeForm";
            this.Text = "SelectClassTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPersonalClassButton2;
        private System.Windows.Forms.Button selectGroupClassButton1;
        private System.Windows.Forms.Button exitButton1;
        private System.Windows.Forms.Label classTypeLabel1;
    }
}