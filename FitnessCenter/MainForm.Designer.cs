using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenter
{
    partial class MainForm
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleScheduleLabel1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.splitter = new System.Windows.Forms.Panel();
            this.scheduleButton1 = new System.Windows.Forms.Button();
            this.analysButton4 = new System.Windows.Forms.Button();
            this.staffButton3 = new System.Windows.Forms.Button();
            this.clientsButton2 = new System.Windows.Forms.Button();
            this.availableSchedulePanel1 = new System.Windows.Forms.Panel();
            this.dateScheduleLabel2 = new System.Windows.Forms.Label();
            this.schedulePanel1 = new System.Windows.Forms.Panel();
            this.clientsPanel2 = new System.Windows.Forms.Panel();
            this.showClientsPanel1 = new System.Windows.Forms.Panel();
            this.createClientsButton = new System.Windows.Forms.Button();
            this.searchResultsClientsPanel1 = new System.Windows.Forms.Panel();
            this.notFoundClientsLabel1 = new System.Windows.Forms.Label();
            this.searchClientsTextBox = new System.Windows.Forms.TextBox();
            this.titleClientsLabel1 = new System.Windows.Forms.Label();
            this.newClientPanel2 = new System.Windows.Forms.Panel();
            this.backCreatingClientButton2 = new System.Windows.Forms.Button();
            this.newClientButton1 = new System.Windows.Forms.Button();
            this.heigthTextBox4 = new System.Windows.Forms.TextBox();
            this.weigthTextBox3 = new System.Windows.Forms.TextBox();
            this.birthDateTextBox2 = new System.Windows.Forms.TextBox();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.newClientLabel2 = new System.Windows.Forms.Label();
            this.clientInfoPanel3 = new System.Windows.Forms.Panel();
            this.addClasseButton3 = new System.Windows.Forms.Button();
            this.signUpButton2 = new System.Windows.Forms.Button();
            this.classesRestLabel4 = new System.Windows.Forms.Label();
            this.visitHistoryButton1 = new System.Windows.Forms.Button();
            this.heightLabel4 = new System.Windows.Forms.Label();
            this.weightLabel3 = new System.Windows.Forms.Label();
            this.birthDateLabel2 = new System.Windows.Forms.Label();
            this.clientNameLabel1 = new System.Windows.Forms.Label();
            this.staffPanel3 = new System.Windows.Forms.Panel();
            this.staffLabel1 = new System.Windows.Forms.Label();
            this.searchResultsStaffPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchStaffTextBox1 = new System.Windows.Forms.TextBox();
            this.schedulePanel1.SuspendLayout();
            this.clientsPanel2.SuspendLayout();
            this.showClientsPanel1.SuspendLayout();
            this.searchResultsClientsPanel1.SuspendLayout();
            this.newClientPanel2.SuspendLayout();
            this.clientInfoPanel3.SuspendLayout();
            this.staffPanel3.SuspendLayout();
            this.searchResultsStaffPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel1.Location = new System.Drawing.Point(518, 21);
            this.titleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(134, 81);
            this.titleLabel1.TabIndex = 4;
            this.titleLabel1.Text = "XFit";
            // 
            // titleScheduleLabel1
            // 
            this.titleScheduleLabel1.AutoSize = true;
            this.titleScheduleLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleScheduleLabel1.Location = new System.Drawing.Point(28, 6);
            this.titleScheduleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleScheduleLabel1.Name = "titleScheduleLabel1";
            this.titleScheduleLabel1.Size = new System.Drawing.Size(358, 81);
            this.titleScheduleLabel1.TabIndex = 5;
            this.titleScheduleLabel1.Text = "Расписание";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(23, 96);
            this.monthCalendar1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.Black;
            this.splitter.Location = new System.Drawing.Point(487, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(2, 450);
            this.splitter.TabIndex = 7;
            // 
            // scheduleButton1
            // 
            this.scheduleButton1.Location = new System.Drawing.Point(498, 126);
            this.scheduleButton1.Name = "scheduleButton1";
            this.scheduleButton1.Size = new System.Drawing.Size(174, 29);
            this.scheduleButton1.TabIndex = 8;
            this.scheduleButton1.Text = "Расписание";
            this.scheduleButton1.UseVisualStyleBackColor = true;
            this.scheduleButton1.Click += new System.EventHandler(this.scheduleButton1_Click);
            // 
            // analysButton4
            // 
            this.analysButton4.Location = new System.Drawing.Point(498, 270);
            this.analysButton4.Name = "analysButton4";
            this.analysButton4.Size = new System.Drawing.Size(174, 29);
            this.analysButton4.TabIndex = 9;
            this.analysButton4.Text = "Анализ";
            this.analysButton4.UseVisualStyleBackColor = true;
            this.analysButton4.Click += new System.EventHandler(this.analysButton4_Click);
            // 
            // staffButton3
            // 
            this.staffButton3.Location = new System.Drawing.Point(498, 220);
            this.staffButton3.Name = "staffButton3";
            this.staffButton3.Size = new System.Drawing.Size(174, 29);
            this.staffButton3.TabIndex = 10;
            this.staffButton3.Text = "Сотрудники";
            this.staffButton3.UseVisualStyleBackColor = true;
            this.staffButton3.Click += new System.EventHandler(this.staffButton3_Click);
            // 
            // clientsButton2
            // 
            this.clientsButton2.Location = new System.Drawing.Point(498, 172);
            this.clientsButton2.Name = "clientsButton2";
            this.clientsButton2.Size = new System.Drawing.Size(174, 29);
            this.clientsButton2.TabIndex = 11;
            this.clientsButton2.Text = "Клиенты";
            this.clientsButton2.UseVisualStyleBackColor = true;
            this.clientsButton2.Click += new System.EventHandler(this.clientsButton2_Click);
            // 
            // availableSchedulePanel1
            // 
            this.availableSchedulePanel1.AutoScroll = true;
            this.availableSchedulePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableSchedulePanel1.Location = new System.Drawing.Point(227, 126);
            this.availableSchedulePanel1.Name = "availableSchedulePanel1";
            this.availableSchedulePanel1.Size = new System.Drawing.Size(242, 177);
            this.availableSchedulePanel1.TabIndex = 15;
            // 
            // dateScheduleLabel2
            // 
            this.dateScheduleLabel2.AutoSize = true;
            this.dateScheduleLabel2.Location = new System.Drawing.Point(309, 96);
            this.dateScheduleLabel2.Name = "dateScheduleLabel2";
            this.dateScheduleLabel2.Size = new System.Drawing.Size(69, 16);
            this.dateScheduleLabel2.TabIndex = 14;
            this.dateScheduleLabel2.Text = "25.04.2024";
            // 
            // schedulePanel1
            // 
            this.schedulePanel1.Controls.Add(this.monthCalendar1);
            this.schedulePanel1.Controls.Add(this.dateScheduleLabel2);
            this.schedulePanel1.Controls.Add(this.availableSchedulePanel1);
            this.schedulePanel1.Controls.Add(this.titleScheduleLabel1);
            this.schedulePanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.schedulePanel1.Location = new System.Drawing.Point(752, 21);
            this.schedulePanel1.Name = "schedulePanel1";
            this.schedulePanel1.Size = new System.Drawing.Size(474, 320);
            this.schedulePanel1.TabIndex = 13;
            // 
            // clientsPanel2
            // 
            this.clientsPanel2.Controls.Add(this.showClientsPanel1);
            this.clientsPanel2.Controls.Add(this.titleClientsLabel1);
            this.clientsPanel2.Controls.Add(this.newClientPanel2);
            this.clientsPanel2.Location = new System.Drawing.Point(710, 370);
            this.clientsPanel2.Name = "clientsPanel2";
            this.clientsPanel2.Size = new System.Drawing.Size(485, 332);
            this.clientsPanel2.TabIndex = 16;
            this.clientsPanel2.Visible = false;
            // 
            // showClientsPanel1
            // 
            this.showClientsPanel1.Controls.Add(this.createClientsButton);
            this.showClientsPanel1.Controls.Add(this.searchResultsClientsPanel1);
            this.showClientsPanel1.Controls.Add(this.searchClientsTextBox);
            this.showClientsPanel1.Location = new System.Drawing.Point(22, 44);
            this.showClientsPanel1.Name = "showClientsPanel1";
            this.showClientsPanel1.Size = new System.Drawing.Size(454, 255);
            this.showClientsPanel1.TabIndex = 4;
            // 
            // createClientsButton
            // 
            this.createClientsButton.Location = new System.Drawing.Point(344, 7);
            this.createClientsButton.Name = "createClientsButton";
            this.createClientsButton.Size = new System.Drawing.Size(94, 29);
            this.createClientsButton.TabIndex = 2;
            this.createClientsButton.Text = "Добавить";
            this.createClientsButton.UseVisualStyleBackColor = true;
            this.createClientsButton.Click += new System.EventHandler(this.createClientsButton_Click);
            // 
            // searchResultsClientsPanel1
            // 
            this.searchResultsClientsPanel1.AutoScroll = true;
            this.searchResultsClientsPanel1.Controls.Add(this.notFoundClientsLabel1);
            this.searchResultsClientsPanel1.Location = new System.Drawing.Point(2, 38);
            this.searchResultsClientsPanel1.Name = "searchResultsClientsPanel1";
            this.searchResultsClientsPanel1.Size = new System.Drawing.Size(441, 213);
            this.searchResultsClientsPanel1.TabIndex = 1;
            // 
            // notFoundClientsLabel1
            // 
            this.notFoundClientsLabel1.AutoSize = true;
            this.notFoundClientsLabel1.Location = new System.Drawing.Point(80, 7);
            this.notFoundClientsLabel1.Name = "notFoundClientsLabel1";
            this.notFoundClientsLabel1.Size = new System.Drawing.Size(263, 16);
            this.notFoundClientsLabel1.TabIndex = 0;
            this.notFoundClientsLabel1.Text = "По вашему запросу ничего не найдено";
            // 
            // searchClientsTextBox
            // 
            this.searchClientsTextBox.Location = new System.Drawing.Point(3, 8);
            this.searchClientsTextBox.Name = "searchClientsTextBox";
            this.searchClientsTextBox.Size = new System.Drawing.Size(330, 22);
            this.searchClientsTextBox.TabIndex = 0;
            this.searchClientsTextBox.TextChanged += new System.EventHandler(this.searchClientsTextBox_TextChanged);
            // 
            // titleClientsLabel1
            // 
            this.titleClientsLabel1.AutoSize = true;
            this.titleClientsLabel1.Location = new System.Drawing.Point(22, 16);
            this.titleClientsLabel1.Name = "titleClientsLabel1";
            this.titleClientsLabel1.Size = new System.Drawing.Size(63, 16);
            this.titleClientsLabel1.TabIndex = 3;
            this.titleClientsLabel1.Text = "Клиенты";
            // 
            // newClientPanel2
            // 
            this.newClientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newClientPanel2.Controls.Add(this.backCreatingClientButton2);
            this.newClientPanel2.Controls.Add(this.newClientButton1);
            this.newClientPanel2.Controls.Add(this.heigthTextBox4);
            this.newClientPanel2.Controls.Add(this.weigthTextBox3);
            this.newClientPanel2.Controls.Add(this.birthDateTextBox2);
            this.newClientPanel2.Controls.Add(this.fullNameTextBox1);
            this.newClientPanel2.Controls.Add(this.newClientLabel2);
            this.newClientPanel2.Location = new System.Drawing.Point(23, 39);
            this.newClientPanel2.Name = "newClientPanel2";
            this.newClientPanel2.Size = new System.Drawing.Size(452, 268);
            this.newClientPanel2.TabIndex = 4;
            this.newClientPanel2.Visible = false;
            // 
            // backCreatingClientButton2
            // 
            this.backCreatingClientButton2.Location = new System.Drawing.Point(239, 181);
            this.backCreatingClientButton2.Name = "backCreatingClientButton2";
            this.backCreatingClientButton2.Size = new System.Drawing.Size(174, 29);
            this.backCreatingClientButton2.TabIndex = 6;
            this.backCreatingClientButton2.Text = "Назад";
            this.backCreatingClientButton2.UseVisualStyleBackColor = true;
            this.backCreatingClientButton2.Click += new System.EventHandler(this.backCreatingClientButton2_Click);
            // 
            // newClientButton1
            // 
            this.newClientButton1.Location = new System.Drawing.Point(37, 181);
            this.newClientButton1.Name = "newClientButton1";
            this.newClientButton1.Size = new System.Drawing.Size(196, 29);
            this.newClientButton1.TabIndex = 5;
            this.newClientButton1.Text = "Добавить";
            this.newClientButton1.UseVisualStyleBackColor = true;
            this.newClientButton1.Click += new System.EventHandler(this.newClientButton1_Click);
            // 
            // heigthTextBox4
            // 
            this.heigthTextBox4.Location = new System.Drawing.Point(286, 140);
            this.heigthTextBox4.Name = "heigthTextBox4";
            this.heigthTextBox4.Size = new System.Drawing.Size(125, 22);
            this.heigthTextBox4.TabIndex = 4;
            // 
            // weigthTextBox3
            // 
            this.weigthTextBox3.Location = new System.Drawing.Point(38, 140);
            this.weigthTextBox3.Name = "weigthTextBox3";
            this.weigthTextBox3.Size = new System.Drawing.Size(125, 22);
            this.weigthTextBox3.TabIndex = 3;
            // 
            // birthDateTextBox2
            // 
            this.birthDateTextBox2.Location = new System.Drawing.Point(38, 92);
            this.birthDateTextBox2.Name = "birthDateTextBox2";
            this.birthDateTextBox2.Size = new System.Drawing.Size(373, 22);
            this.birthDateTextBox2.TabIndex = 2;
            // 
            // fullNameTextBox1
            // 
            this.fullNameTextBox1.Location = new System.Drawing.Point(38, 47);
            this.fullNameTextBox1.Name = "fullNameTextBox1";
            this.fullNameTextBox1.Size = new System.Drawing.Size(373, 22);
            this.fullNameTextBox1.TabIndex = 1;
            // 
            // newClientLabel2
            // 
            this.newClientLabel2.AutoSize = true;
            this.newClientLabel2.Location = new System.Drawing.Point(37, 13);
            this.newClientLabel2.Name = "newClientLabel2";
            this.newClientLabel2.Size = new System.Drawing.Size(99, 16);
            this.newClientLabel2.TabIndex = 0;
            this.newClientLabel2.Text = "Новый клиент";
            // 
            // clientInfoPanel3
            // 
            this.clientInfoPanel3.BackColor = System.Drawing.Color.White;
            this.clientInfoPanel3.Controls.Add(this.addClasseButton3);
            this.clientInfoPanel3.Controls.Add(this.signUpButton2);
            this.clientInfoPanel3.Controls.Add(this.classesRestLabel4);
            this.clientInfoPanel3.Controls.Add(this.visitHistoryButton1);
            this.clientInfoPanel3.Controls.Add(this.heightLabel4);
            this.clientInfoPanel3.Controls.Add(this.weightLabel3);
            this.clientInfoPanel3.Controls.Add(this.birthDateLabel2);
            this.clientInfoPanel3.Controls.Add(this.clientNameLabel1);
            this.clientInfoPanel3.Location = new System.Drawing.Point(1263, 370);
            this.clientInfoPanel3.Name = "clientInfoPanel3";
            this.clientInfoPanel3.Size = new System.Drawing.Size(456, 268);
            this.clientInfoPanel3.TabIndex = 5;
            this.clientInfoPanel3.Visible = false;
            // 
            // addClasseButton3
            // 
            this.addClasseButton3.Location = new System.Drawing.Point(173, 204);
            this.addClasseButton3.Name = "addClasseButton3";
            this.addClasseButton3.Size = new System.Drawing.Size(167, 29);
            this.addClasseButton3.TabIndex = 7;
            this.addClasseButton3.Text = "добавить занятие";
            this.addClasseButton3.UseVisualStyleBackColor = true;
            // 
            // signUpButton2
            // 
            this.signUpButton2.Location = new System.Drawing.Point(173, 169);
            this.signUpButton2.Name = "signUpButton2";
            this.signUpButton2.Size = new System.Drawing.Size(167, 29);
            this.signUpButton2.TabIndex = 6;
            this.signUpButton2.Text = "записать на занятие";
            this.signUpButton2.UseVisualStyleBackColor = true;
            // 
            // classesRestLabel4
            // 
            this.classesRestLabel4.Location = new System.Drawing.Point(182, 140);
            this.classesRestLabel4.Name = "classesRestLabel4";
            this.classesRestLabel4.Size = new System.Drawing.Size(157, 20);
            this.classesRestLabel4.TabIndex = 5;
            this.classesRestLabel4.Text = "label3";
            // 
            // visitHistoryButton1
            // 
            this.visitHistoryButton1.Location = new System.Drawing.Point(173, 98);
            this.visitHistoryButton1.Name = "visitHistoryButton1";
            this.visitHistoryButton1.Size = new System.Drawing.Size(171, 29);
            this.visitHistoryButton1.TabIndex = 4;
            this.visitHistoryButton1.Text = "история посещений";
            this.visitHistoryButton1.UseVisualStyleBackColor = true;
            // 
            // heightLabel4
            // 
            this.heightLabel4.Location = new System.Drawing.Point(184, 73);
            this.heightLabel4.Name = "heightLabel4";
            this.heightLabel4.Size = new System.Drawing.Size(157, 20);
            this.heightLabel4.TabIndex = 3;
            this.heightLabel4.Text = "label2";
            // 
            // weightLabel3
            // 
            this.weightLabel3.Location = new System.Drawing.Point(182, 42);
            this.weightLabel3.Name = "weightLabel3";
            this.weightLabel3.Size = new System.Drawing.Size(157, 20);
            this.weightLabel3.TabIndex = 2;
            this.weightLabel3.Text = "label1";
            // 
            // birthDateLabel2
            // 
            this.birthDateLabel2.Location = new System.Drawing.Point(11, 41);
            this.birthDateLabel2.Name = "birthDateLabel2";
            this.birthDateLabel2.Size = new System.Drawing.Size(148, 20);
            this.birthDateLabel2.TabIndex = 1;
            this.birthDateLabel2.Text = "label1";
            // 
            // clientNameLabel1
            // 
            this.clientNameLabel1.Location = new System.Drawing.Point(12, 12);
            this.clientNameLabel1.Name = "clientNameLabel1";
            this.clientNameLabel1.Size = new System.Drawing.Size(327, 20);
            this.clientNameLabel1.TabIndex = 0;
            this.clientNameLabel1.Text = "label1";
            // 
            // staffPanel3
            // 
            this.staffPanel3.Controls.Add(this.staffLabel1);
            this.staffPanel3.Controls.Add(this.searchResultsStaffPanel1);
            this.staffPanel3.Controls.Add(this.searchStaffTextBox1);
            this.staffPanel3.Location = new System.Drawing.Point(12, 12);
            this.staffPanel3.Name = "staffPanel3";
            this.staffPanel3.Size = new System.Drawing.Size(454, 288);
            this.staffPanel3.TabIndex = 5;
            this.staffPanel3.Visible = false;
            // 
            // staffLabel1
            // 
            this.staffLabel1.AutoSize = true;
            this.staffLabel1.Location = new System.Drawing.Point(3, 13);
            this.staffLabel1.Name = "staffLabel1";
            this.staffLabel1.Size = new System.Drawing.Size(86, 16);
            this.staffLabel1.TabIndex = 5;
            this.staffLabel1.Text = "Сотрудники";
            // 
            // searchResultsStaffPanel1
            // 
            this.searchResultsStaffPanel1.Controls.Add(this.label1);
            this.searchResultsStaffPanel1.Location = new System.Drawing.Point(2, 62);
            this.searchResultsStaffPanel1.Name = "searchResultsStaffPanel1";
            this.searchResultsStaffPanel1.Size = new System.Drawing.Size(441, 213);
            this.searchResultsStaffPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "По вашему запросу ничего не найдено";
            // 
            // searchStaffTextBox1
            // 
            this.searchStaffTextBox1.Location = new System.Drawing.Point(3, 32);
            this.searchStaffTextBox1.Name = "searchStaffTextBox1";
            this.searchStaffTextBox1.Size = new System.Drawing.Size(440, 22);
            this.searchStaffTextBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1736, 720);
            this.Controls.Add(this.staffPanel3);
            this.Controls.Add(this.clientsButton2);
            this.Controls.Add(this.staffButton3);
            this.Controls.Add(this.analysButton4);
            this.Controls.Add(this.scheduleButton1);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.schedulePanel1);
            this.Controls.Add(this.clientInfoPanel3);
            this.Controls.Add(this.clientsPanel2);
            this.Name = "MainForm";
            this.Text = " XFIT";
            this.schedulePanel1.ResumeLayout(false);
            this.schedulePanel1.PerformLayout();
            this.clientsPanel2.ResumeLayout(false);
            this.clientsPanel2.PerformLayout();
            this.showClientsPanel1.ResumeLayout(false);
            this.showClientsPanel1.PerformLayout();
            this.searchResultsClientsPanel1.ResumeLayout(false);
            this.searchResultsClientsPanel1.PerformLayout();
            this.newClientPanel2.ResumeLayout(false);
            this.newClientPanel2.PerformLayout();
            this.clientInfoPanel3.ResumeLayout(false);
            this.staffPanel3.ResumeLayout(false);
            this.staffPanel3.PerformLayout();
            this.searchResultsStaffPanel1.ResumeLayout(false);
            this.searchResultsStaffPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel1;
        private Label titleScheduleLabel1;
        private MonthCalendar monthCalendar1;
        private Panel splitter;
        private Button scheduleButton1;
        private Button analysButton4;
        private Button staffButton3;
        private Button clientsButton2;
        private Panel availableSchedulePanel1;
        private Label dateScheduleLabel2;
        private Panel schedulePanel1;
        private Panel clientsPanel2;
        private TextBox searchClientsTextBox;
        private Button createClientsButton;
        private Label titleClientsLabel1;
        private Panel newClientPanel2;
        private TextBox birthDateTextBox2;
        private TextBox fullNameTextBox1;
        private Label newClientLabel2;
        private Button newClientButton1;
        private TextBox heigthTextBox4;
        private TextBox weigthTextBox3;
        private Panel showClientsPanel1;
        private Button backCreatingClientButton2;
        private Panel clientInfoPanel3;
        private Button addClasseButton3;
        private Button signUpButton2;
        private Label classesRestLabel4;
        private Button visitHistoryButton1;
        private Label heightLabel4;
        private Label weightLabel3;
        private Label birthDateLabel2;
        private Panel searchResultsClientsPanel1;
        private Label notFoundClientsLabel1;
        private Label clientNameLabel1;
        private Panel staffPanel3;
        private Panel searchResultsStaffPanel1;
        private Label label1;
        private TextBox searchStaffTextBox1;
        private Label staffLabel1;
    }
}