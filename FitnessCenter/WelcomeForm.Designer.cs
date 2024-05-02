namespace FitnesCenter
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Panel();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autorizeButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("TTMoons-Bold", 9F);
            this.titleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.titleLabel1.Location = new System.Drawing.Point(13, 13);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(145, 19);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "ФИТНЕС ЦЕНТР XFIT";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.splitter.Location = new System.Drawing.Point(20, 38);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(661, 1);
            this.splitter.TabIndex = 1;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Safira March Personal Use", 22.2F);
            this.titleLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.titleLabel2.Location = new System.Drawing.Point(464, 42);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(149, 90);
            this.titleLabel2.TabIndex = 2;
            this.titleLabel2.Text = "XFit";
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox1.Font = new System.Drawing.Font("TT Commons", 9F);
            this.loginTextBox1.Location = new System.Drawing.Point(432, 139);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(208, 25);
            this.loginTextBox1.TabIndex = 3;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox2.Font = new System.Drawing.Font("TT Commons", 9F);
            this.passwordTextBox2.Location = new System.Drawing.Point(432, 193);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(208, 25);
            this.passwordTextBox2.TabIndex = 4;
            this.passwordTextBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenter.Properties.Resources.res1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 330);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // autorizeButton1
            // 
            this.autorizeButton1.Font = new System.Drawing.Font("TT Commons", 9F);
            this.autorizeButton1.Location = new System.Drawing.Point(478, 244);
            this.autorizeButton1.Name = "autorizeButton1";
            this.autorizeButton1.Size = new System.Drawing.Size(116, 30);
            this.autorizeButton1.TabIndex = 6;
            this.autorizeButton1.Text = "ВОЙТИ";
            this.autorizeButton1.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.autorizeButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.titleLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Panel splitter;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.TextBox loginTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button autorizeButton1;
    }
}

