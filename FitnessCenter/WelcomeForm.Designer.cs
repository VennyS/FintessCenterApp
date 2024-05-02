using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenter
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.autorizeButton1 = new System.Windows.Forms.Button();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenter.Properties.Resources.res1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 330);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Safira March Personal Use", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.titleLabel2.Location = new System.Drawing.Point(464, 42);
            this.titleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(149, 90);
            this.titleLabel2.TabIndex = 3;
            this.titleLabel2.Text = "XFit";
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox1.Font = new System.Drawing.Font("TT Commons", 9F);
            this.loginTextBox1.Location = new System.Drawing.Point(432, 139);
            this.loginTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(208, 25);
            this.loginTextBox1.TabIndex = 4;
            this.loginTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTextBox1.UseSystemPasswordChar = true;
            this.loginTextBox1.Enter += new System.EventHandler(this.loginTextBox1_Enter);
            this.loginTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox1_KeyDown);
            this.loginTextBox1.Leave += new System.EventHandler(this.loginTextBox1_Leave);
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox2.Font = new System.Drawing.Font("TT Commons", 9F);
            this.passwordTextBox2.Location = new System.Drawing.Point(432, 193);
            this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(208, 25);
            this.passwordTextBox2.TabIndex = 5;
            this.passwordTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox2.Enter += new System.EventHandler(this.passwordTextBox2_Enter);
            this.passwordTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox2_KeyDown);
            this.passwordTextBox2.Leave += new System.EventHandler(this.passwordTextBox2_Leave);
            // 
            // autorizeButton1
            // 
            this.autorizeButton1.BackColor = System.Drawing.Color.White;
            this.autorizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autorizeButton1.Font = new System.Drawing.Font("TT Commons", 9F);
            this.autorizeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.autorizeButton1.Location = new System.Drawing.Point(478, 244);
            this.autorizeButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorizeButton1.Name = "autorizeButton1";
            this.autorizeButton1.Size = new System.Drawing.Size(116, 30);
            this.autorizeButton1.TabIndex = 6;
            this.autorizeButton1.Text = "ВОЙТИ";
            this.autorizeButton1.UseVisualStyleBackColor = false;
            this.autorizeButton1.Click += new System.EventHandler(this.autorizeButton1_Click);
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("TTMoons-Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.titleLabel1.Location = new System.Drawing.Point(20, 9);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(145, 19);
            this.titleLabel1.TabIndex = 7;
            this.titleLabel1.Text = "ФИТНЕС ЦЕНТР XFIT";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.splitter.Location = new System.Drawing.Point(20, 38);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(661, 1);
            this.splitter.TabIndex = 8;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.autorizeButton1);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label titleLabel2;
        private TextBox loginTextBox1;
        private TextBox passwordTextBox2;
        private Button autorizeButton1;
        private Label titleLabel1;
        private Panel splitter;
    }
}
