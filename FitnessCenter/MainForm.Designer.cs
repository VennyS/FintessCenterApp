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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleScheduleLabel1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.splitter = new System.Windows.Forms.Panel();
            this.scheduleButton1 = new System.Windows.Forms.Button();
            this.analysButton4 = new System.Windows.Forms.Button();
            this.staffButton3 = new System.Windows.Forms.Button();
            this.clientsButton2 = new System.Windows.Forms.Button();
            this.dateScheduleLabel2 = new System.Windows.Forms.Label();
            this.schedulePanel1 = new System.Windows.Forms.Panel();
            this.signUpToGroupClassButton1 = new System.Windows.Forms.Button();
            this.timesListBox2 = new System.Windows.Forms.ListBox();
            this.typesOfClassesListBox1 = new System.Windows.Forms.ListBox();
            this.clientsPanel2 = new System.Windows.Forms.Panel();
            this.titleClientsLabel1 = new System.Windows.Forms.Label();
            this.showClientsPanel1 = new System.Windows.Forms.Panel();
            this.createClientsButton1 = new System.Windows.Forms.Button();
            this.searchClientsTextBox = new System.Windows.Forms.TextBox();
            this.newClientPanel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backCreatingClientButton2 = new System.Windows.Forms.Button();
            this.newClientButton1 = new System.Windows.Forms.Button();
            this.heigthTextBox4 = new System.Windows.Forms.TextBox();
            this.weigthTextBox3 = new System.Windows.Forms.TextBox();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.newClientLabel2 = new System.Windows.Forms.Label();
            this.clientInfoPanel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addClasseButton3 = new System.Windows.Forms.Button();
            this.signUpButton2 = new System.Windows.Forms.Button();
            this.classesRestLabel5 = new System.Windows.Forms.Label();
            this.visitHistoryButton1 = new System.Windows.Forms.Button();
            this.heightLabel4 = new System.Windows.Forms.Label();
            this.weightLabel3 = new System.Windows.Forms.Label();
            this.birthDateLabel2 = new System.Windows.Forms.Label();
            this.clientNameLabel1 = new System.Windows.Forms.Label();
            this.staffPanel3 = new System.Windows.Forms.Panel();
            this.searchStaffPanel1 = new System.Windows.Forms.Panel();
            this.selectEmployeeButton1 = new System.Windows.Forms.Button();
            this.searchStaffResultListBox1 = new System.Windows.Forms.ListBox();
            this.searchStaffTextBox1 = new System.Windows.Forms.TextBox();
            this.staffLabel1 = new System.Windows.Forms.Label();
            this.visitHistoryPanel6 = new System.Windows.Forms.Panel();
            this.clientNameLabel2 = new System.Windows.Forms.Label();
            this.individualClassesPanel2 = new System.Windows.Forms.Panel();
            this.individualClassesListBox2 = new System.Windows.Forms.ListBox();
            this.employeeInfoButton1 = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.invidualClassesLabel2 = new System.Windows.Forms.Label();
            this.invidualClassesLabel1 = new System.Windows.Forms.Label();
            this.analysisPanel4 = new System.Windows.Forms.Panel();
            this.incomeLabel3 = new System.Windows.Forms.Label();
            this.clientCountLabel2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analysisLabel1 = new System.Windows.Forms.Label();
            this.searchResultsClientsListBox1 = new System.Windows.Forms.ListBox();
            this.chooseClientButton2 = new System.Windows.Forms.Button();
            this.deleteClientButton3 = new System.Windows.Forms.Button();
            this.visitsShowListBox1 = new System.Windows.Forms.ListBox();
            this.backFromVisitHistoryButton1 = new System.Windows.Forms.Button();
            this.backFromClientInfoButton4 = new System.Windows.Forms.Button();
            this.selectInvidialClassButton2 = new System.Windows.Forms.Button();
            this.schedulePanel1.SuspendLayout();
            this.clientsPanel2.SuspendLayout();
            this.showClientsPanel1.SuspendLayout();
            this.newClientPanel2.SuspendLayout();
            this.clientInfoPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.staffPanel3.SuspendLayout();
            this.searchStaffPanel1.SuspendLayout();
            this.visitHistoryPanel6.SuspendLayout();
            this.individualClassesPanel2.SuspendLayout();
            this.analysisPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel1.Location = new System.Drawing.Point(518, 21);
            this.titleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(107, 65);
            this.titleLabel1.TabIndex = 4;
            this.titleLabel1.Text = "XFit";
            // 
            // titleScheduleLabel1
            // 
            this.titleScheduleLabel1.AutoSize = true;
            this.titleScheduleLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.titleScheduleLabel1.Location = new System.Drawing.Point(21, 11);
            this.titleScheduleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleScheduleLabel1.Name = "titleScheduleLabel1";
            this.titleScheduleLabel1.Size = new System.Drawing.Size(228, 32);
            this.titleScheduleLabel1.TabIndex = 5;
            this.titleScheduleLabel1.Text = "Групповые занятия";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(23, 62);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.scheduleButton1.Text = "Групповые занятия";
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
            this.staffButton3.Text = "Индивидуальные занятия";
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
            // dateScheduleLabel2
            // 
            this.dateScheduleLabel2.Location = new System.Drawing.Point(286, 62);
            this.dateScheduleLabel2.Name = "dateScheduleLabel2";
            this.dateScheduleLabel2.Size = new System.Drawing.Size(69, 19);
            this.dateScheduleLabel2.TabIndex = 14;
            this.dateScheduleLabel2.Text = "25.04.2024";
            // 
            // schedulePanel1
            // 
            this.schedulePanel1.Controls.Add(this.signUpToGroupClassButton1);
            this.schedulePanel1.Controls.Add(this.timesListBox2);
            this.schedulePanel1.Controls.Add(this.typesOfClassesListBox1);
            this.schedulePanel1.Controls.Add(this.monthCalendar1);
            this.schedulePanel1.Controls.Add(this.dateScheduleLabel2);
            this.schedulePanel1.Controls.Add(this.titleScheduleLabel1);
            this.schedulePanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.schedulePanel1.Location = new System.Drawing.Point(710, 25);
            this.schedulePanel1.Name = "schedulePanel1";
            this.schedulePanel1.Size = new System.Drawing.Size(474, 244);
            this.schedulePanel1.TabIndex = 13;
            // 
            // signUpToGroupClassButton1
            // 
            this.signUpToGroupClassButton1.Location = new System.Drawing.Point(201, 201);
            this.signUpToGroupClassButton1.Name = "signUpToGroupClassButton1";
            this.signUpToGroupClassButton1.Size = new System.Drawing.Size(240, 23);
            this.signUpToGroupClassButton1.TabIndex = 17;
            this.signUpToGroupClassButton1.Text = "записать";
            this.signUpToGroupClassButton1.UseVisualStyleBackColor = true;
            this.signUpToGroupClassButton1.Click += new System.EventHandler(this.signUpToGroupClassButton1_Click);
            // 
            // timesListBox2
            // 
            this.timesListBox2.DisplayMember = "dateTime";
            this.timesListBox2.FormatString = "t";
            this.timesListBox2.FormattingEnabled = true;
            this.timesListBox2.Location = new System.Drawing.Point(201, 138);
            this.timesListBox2.Name = "timesListBox2";
            this.timesListBox2.Size = new System.Drawing.Size(238, 56);
            this.timesListBox2.TabIndex = 16;
            // 
            // typesOfClassesListBox1
            // 
            this.typesOfClassesListBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.typesOfClassesListBox1.DisplayMember = "name";
            this.typesOfClassesListBox1.FormattingEnabled = true;
            this.typesOfClassesListBox1.Location = new System.Drawing.Point(199, 84);
            this.typesOfClassesListBox1.Name = "typesOfClassesListBox1";
            this.typesOfClassesListBox1.Size = new System.Drawing.Size(240, 43);
            this.typesOfClassesListBox1.TabIndex = 15;
            this.typesOfClassesListBox1.SelectedIndexChanged += new System.EventHandler(this.typesOfClassesListBox1_SelectedIndexChanged);
            // 
            // clientsPanel2
            // 
            this.clientsPanel2.Controls.Add(this.titleClientsLabel1);
            this.clientsPanel2.Controls.Add(this.clientInfoPanel3);
            this.clientsPanel2.Controls.Add(this.newClientPanel2);
            this.clientsPanel2.Controls.Add(this.showClientsPanel1);
            this.clientsPanel2.Location = new System.Drawing.Point(710, 370);
            this.clientsPanel2.Name = "clientsPanel2";
            this.clientsPanel2.Size = new System.Drawing.Size(485, 332);
            this.clientsPanel2.TabIndex = 16;
            this.clientsPanel2.Visible = false;
            // 
            // titleClientsLabel1
            // 
            this.titleClientsLabel1.AutoSize = true;
            this.titleClientsLabel1.Location = new System.Drawing.Point(22, 16);
            this.titleClientsLabel1.Name = "titleClientsLabel1";
            this.titleClientsLabel1.Size = new System.Drawing.Size(51, 13);
            this.titleClientsLabel1.TabIndex = 3;
            this.titleClientsLabel1.Text = "Клиенты";
            // 
            // showClientsPanel1
            // 
            this.showClientsPanel1.Controls.Add(this.deleteClientButton3);
            this.showClientsPanel1.Controls.Add(this.chooseClientButton2);
            this.showClientsPanel1.Controls.Add(this.searchResultsClientsListBox1);
            this.showClientsPanel1.Controls.Add(this.createClientsButton1);
            this.showClientsPanel1.Controls.Add(this.searchClientsTextBox);
            this.showClientsPanel1.Location = new System.Drawing.Point(22, 44);
            this.showClientsPanel1.Name = "showClientsPanel1";
            this.showClientsPanel1.Size = new System.Drawing.Size(454, 255);
            this.showClientsPanel1.TabIndex = 4;
            // 
            // createClientsButton1
            // 
            this.createClientsButton1.Location = new System.Drawing.Point(344, 7);
            this.createClientsButton1.Name = "createClientsButton1";
            this.createClientsButton1.Size = new System.Drawing.Size(94, 29);
            this.createClientsButton1.TabIndex = 2;
            this.createClientsButton1.Text = "Добавить";
            this.createClientsButton1.UseVisualStyleBackColor = true;
            this.createClientsButton1.Click += new System.EventHandler(this.createClientsButton_Click);
            // 
            // searchClientsTextBox
            // 
            this.searchClientsTextBox.Location = new System.Drawing.Point(3, 8);
            this.searchClientsTextBox.Name = "searchClientsTextBox";
            this.searchClientsTextBox.Size = new System.Drawing.Size(330, 20);
            this.searchClientsTextBox.TabIndex = 0;
            this.searchClientsTextBox.TextChanged += new System.EventHandler(this.searchClientsTextBox_TextChanged);
            // 
            // newClientPanel2
            // 
            this.newClientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newClientPanel2.Controls.Add(this.dateTimePicker1);
            this.newClientPanel2.Controls.Add(this.backCreatingClientButton2);
            this.newClientPanel2.Controls.Add(this.newClientButton1);
            this.newClientPanel2.Controls.Add(this.heigthTextBox4);
            this.newClientPanel2.Controls.Add(this.weigthTextBox3);
            this.newClientPanel2.Controls.Add(this.fullNameTextBox1);
            this.newClientPanel2.Controls.Add(this.newClientLabel2);
            this.newClientPanel2.Location = new System.Drawing.Point(23, 39);
            this.newClientPanel2.Name = "newClientPanel2";
            this.newClientPanel2.Size = new System.Drawing.Size(452, 268);
            this.newClientPanel2.TabIndex = 4;
            this.newClientPanel2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 20);
            this.dateTimePicker1.TabIndex = 7;
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
            this.heigthTextBox4.Size = new System.Drawing.Size(125, 20);
            this.heigthTextBox4.TabIndex = 4;
            // 
            // weigthTextBox3
            // 
            this.weigthTextBox3.Location = new System.Drawing.Point(38, 140);
            this.weigthTextBox3.Name = "weigthTextBox3";
            this.weigthTextBox3.Size = new System.Drawing.Size(125, 20);
            this.weigthTextBox3.TabIndex = 3;
            // 
            // fullNameTextBox1
            // 
            this.fullNameTextBox1.Location = new System.Drawing.Point(38, 47);
            this.fullNameTextBox1.Name = "fullNameTextBox1";
            this.fullNameTextBox1.Size = new System.Drawing.Size(373, 20);
            this.fullNameTextBox1.TabIndex = 1;
            // 
            // newClientLabel2
            // 
            this.newClientLabel2.AutoSize = true;
            this.newClientLabel2.Location = new System.Drawing.Point(37, 13);
            this.newClientLabel2.Name = "newClientLabel2";
            this.newClientLabel2.Size = new System.Drawing.Size(79, 13);
            this.newClientLabel2.TabIndex = 0;
            this.newClientLabel2.Text = "Новый клиент";
            // 
            // clientInfoPanel3
            // 
            this.clientInfoPanel3.BackColor = System.Drawing.Color.White;
            this.clientInfoPanel3.Controls.Add(this.backFromClientInfoButton4);
            this.clientInfoPanel3.Controls.Add(this.chart1);
            this.clientInfoPanel3.Controls.Add(this.addClasseButton3);
            this.clientInfoPanel3.Controls.Add(this.signUpButton2);
            this.clientInfoPanel3.Controls.Add(this.classesRestLabel5);
            this.clientInfoPanel3.Controls.Add(this.visitHistoryButton1);
            this.clientInfoPanel3.Controls.Add(this.heightLabel4);
            this.clientInfoPanel3.Controls.Add(this.weightLabel3);
            this.clientInfoPanel3.Controls.Add(this.birthDateLabel2);
            this.clientInfoPanel3.Controls.Add(this.clientNameLabel1);
            this.clientInfoPanel3.Location = new System.Drawing.Point(23, 39);
            this.clientInfoPanel3.Name = "clientInfoPanel3";
            this.clientInfoPanel3.Size = new System.Drawing.Size(456, 281);
            this.clientInfoPanel3.TabIndex = 5;
            this.clientInfoPanel3.Visible = false;
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend9.Name = "Посещения";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(4, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Посещения";
            series9.LegendText = "Посещения";
            series9.Name = "Посещения";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(269, 243);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // addClasseButton3
            // 
            this.addClasseButton3.Location = new System.Drawing.Point(278, 181);
            this.addClasseButton3.Name = "addClasseButton3";
            this.addClasseButton3.Size = new System.Drawing.Size(167, 29);
            this.addClasseButton3.TabIndex = 7;
            this.addClasseButton3.Text = "добавить занятие";
            this.addClasseButton3.UseVisualStyleBackColor = true;
            this.addClasseButton3.Click += new System.EventHandler(this.addClasseButton3_Click);
            // 
            // signUpButton2
            // 
            this.signUpButton2.Location = new System.Drawing.Point(278, 140);
            this.signUpButton2.Name = "signUpButton2";
            this.signUpButton2.Size = new System.Drawing.Size(167, 29);
            this.signUpButton2.TabIndex = 6;
            this.signUpButton2.Text = "записать на занятие";
            this.signUpButton2.UseVisualStyleBackColor = true;
            this.signUpButton2.Click += new System.EventHandler(this.signUpButton2_Click);
            // 
            // classesRestLabel5
            // 
            this.classesRestLabel5.Location = new System.Drawing.Point(283, 107);
            this.classesRestLabel5.Name = "classesRestLabel5";
            this.classesRestLabel5.Size = new System.Drawing.Size(162, 36);
            this.classesRestLabel5.TabIndex = 5;
            this.classesRestLabel5.Text = "Количество оставшихся занятий";
            // 
            // visitHistoryButton1
            // 
            this.visitHistoryButton1.Location = new System.Drawing.Point(278, 75);
            this.visitHistoryButton1.Name = "visitHistoryButton1";
            this.visitHistoryButton1.Size = new System.Drawing.Size(171, 29);
            this.visitHistoryButton1.TabIndex = 4;
            this.visitHistoryButton1.Text = "история посещений";
            this.visitHistoryButton1.UseVisualStyleBackColor = true;
            this.visitHistoryButton1.Click += new System.EventHandler(this.visitHistoryButton1_Click);
            // 
            // heightLabel4
            // 
            this.heightLabel4.Location = new System.Drawing.Point(362, 50);
            this.heightLabel4.Name = "heightLabel4";
            this.heightLabel4.Size = new System.Drawing.Size(83, 20);
            this.heightLabel4.TabIndex = 3;
            this.heightLabel4.Text = "Рост";
            // 
            // weightLabel3
            // 
            this.weightLabel3.Location = new System.Drawing.Point(287, 49);
            this.weightLabel3.Name = "weightLabel3";
            this.weightLabel3.Size = new System.Drawing.Size(69, 20);
            this.weightLabel3.TabIndex = 2;
            this.weightLabel3.Text = "Вес";
            // 
            // birthDateLabel2
            // 
            this.birthDateLabel2.Location = new System.Drawing.Point(283, 12);
            this.birthDateLabel2.Name = "birthDateLabel2";
            this.birthDateLabel2.Size = new System.Drawing.Size(153, 20);
            this.birthDateLabel2.TabIndex = 1;
            this.birthDateLabel2.Text = "День рождения";
            // 
            // clientNameLabel1
            // 
            this.clientNameLabel1.Location = new System.Drawing.Point(12, 12);
            this.clientNameLabel1.Name = "clientNameLabel1";
            this.clientNameLabel1.Size = new System.Drawing.Size(147, 20);
            this.clientNameLabel1.TabIndex = 0;
            this.clientNameLabel1.Text = "Имя клиента";
            // 
            // staffPanel3
            // 
            this.staffPanel3.Controls.Add(this.searchStaffPanel1);
            this.staffPanel3.Controls.Add(this.staffLabel1);
            this.staffPanel3.Location = new System.Drawing.Point(7, 12);
            this.staffPanel3.Name = "staffPanel3";
            this.staffPanel3.Size = new System.Drawing.Size(469, 287);
            this.staffPanel3.TabIndex = 5;
            this.staffPanel3.Visible = false;
            // 
            // searchStaffPanel1
            // 
            this.searchStaffPanel1.Controls.Add(this.selectEmployeeButton1);
            this.searchStaffPanel1.Controls.Add(this.searchStaffResultListBox1);
            this.searchStaffPanel1.Controls.Add(this.searchStaffTextBox1);
            this.searchStaffPanel1.Location = new System.Drawing.Point(8, 32);
            this.searchStaffPanel1.Name = "searchStaffPanel1";
            this.searchStaffPanel1.Size = new System.Drawing.Size(451, 249);
            this.searchStaffPanel1.TabIndex = 20;
            // 
            // selectEmployeeButton1
            // 
            this.selectEmployeeButton1.Location = new System.Drawing.Point(0, 217);
            this.selectEmployeeButton1.Name = "selectEmployeeButton1";
            this.selectEmployeeButton1.Size = new System.Drawing.Size(440, 23);
            this.selectEmployeeButton1.TabIndex = 2;
            this.selectEmployeeButton1.Text = "выбрать";
            this.selectEmployeeButton1.UseVisualStyleBackColor = true;
            this.selectEmployeeButton1.Click += new System.EventHandler(this.selectEmployeeButton1_Click);
            // 
            // searchStaffResultListBox1
            // 
            this.searchStaffResultListBox1.DisplayMember = "name";
            this.searchStaffResultListBox1.FormattingEnabled = true;
            this.searchStaffResultListBox1.Location = new System.Drawing.Point(4, 31);
            this.searchStaffResultListBox1.Name = "searchStaffResultListBox1";
            this.searchStaffResultListBox1.Size = new System.Drawing.Size(440, 173);
            this.searchStaffResultListBox1.TabIndex = 1;
            // 
            // searchStaffTextBox1
            // 
            this.searchStaffTextBox1.Location = new System.Drawing.Point(4, 4);
            this.searchStaffTextBox1.Name = "searchStaffTextBox1";
            this.searchStaffTextBox1.Size = new System.Drawing.Size(440, 20);
            this.searchStaffTextBox1.TabIndex = 0;
            this.searchStaffTextBox1.TextChanged += new System.EventHandler(this.searchStaffTextBox1_TextChanged);
            // 
            // staffLabel1
            // 
            this.staffLabel1.AutoSize = true;
            this.staffLabel1.Location = new System.Drawing.Point(3, 13);
            this.staffLabel1.Name = "staffLabel1";
            this.staffLabel1.Size = new System.Drawing.Size(66, 13);
            this.staffLabel1.TabIndex = 5;
            this.staffLabel1.Text = "Сотрудники";
            // 
            // visitHistoryPanel6
            // 
            this.visitHistoryPanel6.Controls.Add(this.visitsShowListBox1);
            this.visitHistoryPanel6.Controls.Add(this.clientNameLabel2);
            this.visitHistoryPanel6.Controls.Add(this.backFromVisitHistoryButton1);
            this.visitHistoryPanel6.Location = new System.Drawing.Point(1247, 12);
            this.visitHistoryPanel6.Name = "visitHistoryPanel6";
            this.visitHistoryPanel6.Size = new System.Drawing.Size(456, 281);
            this.visitHistoryPanel6.TabIndex = 19;
            this.visitHistoryPanel6.Visible = false;
            // 
            // clientNameLabel2
            // 
            this.clientNameLabel2.Location = new System.Drawing.Point(12, 9);
            this.clientNameLabel2.Name = "clientNameLabel2";
            this.clientNameLabel2.Size = new System.Drawing.Size(147, 20);
            this.clientNameLabel2.TabIndex = 10;
            this.clientNameLabel2.Text = "Имя клиента";
            // 
            // individualClassesPanel2
            // 
            this.individualClassesPanel2.Controls.Add(this.selectInvidialClassButton2);
            this.individualClassesPanel2.Controls.Add(this.individualClassesListBox2);
            this.individualClassesPanel2.Controls.Add(this.employeeInfoButton1);
            this.individualClassesPanel2.Controls.Add(this.monthCalendar2);
            this.individualClassesPanel2.Controls.Add(this.invidualClassesLabel2);
            this.individualClassesPanel2.Controls.Add(this.invidualClassesLabel1);
            this.individualClassesPanel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.individualClassesPanel2.Location = new System.Drawing.Point(7, 317);
            this.individualClassesPanel2.Name = "individualClassesPanel2";
            this.individualClassesPanel2.Size = new System.Drawing.Size(474, 296);
            this.individualClassesPanel2.TabIndex = 16;
            this.individualClassesPanel2.Visible = false;
            // 
            // individualClassesListBox2
            // 
            this.individualClassesListBox2.DisplayMember = "name";
            this.individualClassesListBox2.FormattingEnabled = true;
            this.individualClassesListBox2.Location = new System.Drawing.Point(199, 150);
            this.individualClassesListBox2.Name = "individualClassesListBox2";
            this.individualClassesListBox2.Size = new System.Drawing.Size(247, 95);
            this.individualClassesListBox2.TabIndex = 17;
            // 
            // employeeInfoButton1
            // 
            this.employeeInfoButton1.Location = new System.Drawing.Point(23, 69);
            this.employeeInfoButton1.Name = "employeeInfoButton1";
            this.employeeInfoButton1.Size = new System.Drawing.Size(436, 35);
            this.employeeInfoButton1.TabIndex = 16;
            this.employeeInfoButton1.Text = "button1";
            this.employeeInfoButton1.UseVisualStyleBackColor = true;
            this.employeeInfoButton1.Click += new System.EventHandler(this.employeeInfoButton1_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar2.Location = new System.Drawing.Point(23, 111);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // invidualClassesLabel2
            // 
            this.invidualClassesLabel2.AutoSize = true;
            this.invidualClassesLabel2.Location = new System.Drawing.Point(292, 127);
            this.invidualClassesLabel2.Name = "invidualClassesLabel2";
            this.invidualClassesLabel2.Size = new System.Drawing.Size(61, 13);
            this.invidualClassesLabel2.TabIndex = 14;
            this.invidualClassesLabel2.Text = "25.04.2024";
            // 
            // invidualClassesLabel1
            // 
            this.invidualClassesLabel1.AutoSize = true;
            this.invidualClassesLabel1.BackColor = System.Drawing.Color.Transparent;
            this.invidualClassesLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.invidualClassesLabel1.Location = new System.Drawing.Point(28, 20);
            this.invidualClassesLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invidualClassesLabel1.Name = "invidualClassesLabel1";
            this.invidualClassesLabel1.Size = new System.Drawing.Size(298, 32);
            this.invidualClassesLabel1.TabIndex = 5;
            this.invidualClassesLabel1.Text = "Индивидуальные занятия";
            // 
            // analysisPanel4
            // 
            this.analysisPanel4.Controls.Add(this.incomeLabel3);
            this.analysisPanel4.Controls.Add(this.clientCountLabel2);
            this.analysisPanel4.Controls.Add(this.chart2);
            this.analysisPanel4.Controls.Add(this.analysisLabel1);
            this.analysisPanel4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.analysisPanel4.Location = new System.Drawing.Point(7, 669);
            this.analysisPanel4.Name = "analysisPanel4";
            this.analysisPanel4.Size = new System.Drawing.Size(474, 320);
            this.analysisPanel4.TabIndex = 16;
            // 
            // incomeLabel3
            // 
            this.incomeLabel3.AutoSize = true;
            this.incomeLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.incomeLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomeLabel3.Location = new System.Drawing.Point(229, 44);
            this.incomeLabel3.Name = "incomeLabel3";
            this.incomeLabel3.Size = new System.Drawing.Size(91, 15);
            this.incomeLabel3.TabIndex = 3;
            this.incomeLabel3.Text = "Прибыль: 10000";
            // 
            // clientCountLabel2
            // 
            this.clientCountLabel2.AutoSize = true;
            this.clientCountLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.clientCountLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientCountLabel2.Location = new System.Drawing.Point(23, 44);
            this.clientCountLabel2.Name = "clientCountLabel2";
            this.clientCountLabel2.Size = new System.Drawing.Size(160, 15);
            this.clientCountLabel2.TabIndex = 2;
            this.clientCountLabel2.Text = "Количество клиентов: 100000";
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(19, 75);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(414, 230);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // analysisLabel1
            // 
            this.analysisLabel1.AutoSize = true;
            this.analysisLabel1.Location = new System.Drawing.Point(8, 16);
            this.analysisLabel1.Name = "analysisLabel1";
            this.analysisLabel1.Size = new System.Drawing.Size(44, 13);
            this.analysisLabel1.TabIndex = 0;
            this.analysisLabel1.Text = "Анализ";
            // 
            // searchResultsClientsListBox1
            // 
            this.searchResultsClientsListBox1.FormattingEnabled = true;
            this.searchResultsClientsListBox1.Location = new System.Drawing.Point(5, 41);
            this.searchResultsClientsListBox1.Name = "searchResultsClientsListBox1";
            this.searchResultsClientsListBox1.Size = new System.Drawing.Size(433, 186);
            this.searchResultsClientsListBox1.TabIndex = 3;
            // 
            // chooseClientButton2
            // 
            this.chooseClientButton2.Location = new System.Drawing.Point(5, 229);
            this.chooseClientButton2.Name = "chooseClientButton2";
            this.chooseClientButton2.Size = new System.Drawing.Size(229, 23);
            this.chooseClientButton2.TabIndex = 4;
            this.chooseClientButton2.Text = "выбрать";
            this.chooseClientButton2.UseVisualStyleBackColor = true;
            this.chooseClientButton2.Click += new System.EventHandler(this.chooseClientButton2_Click);
            // 
            // deleteClientButton3
            // 
            this.deleteClientButton3.Location = new System.Drawing.Point(240, 228);
            this.deleteClientButton3.Name = "deleteClientButton3";
            this.deleteClientButton3.Size = new System.Drawing.Size(198, 23);
            this.deleteClientButton3.TabIndex = 5;
            this.deleteClientButton3.Text = "удалить";
            this.deleteClientButton3.UseVisualStyleBackColor = true;
            this.deleteClientButton3.Click += new System.EventHandler(this.deleteClientButton3_Click);
            // 
            // visitsShowListBox1
            // 
            this.visitsShowListBox1.FormattingEnabled = true;
            this.visitsShowListBox1.Location = new System.Drawing.Point(15, 36);
            this.visitsShowListBox1.Name = "visitsShowListBox1";
            this.visitsShowListBox1.Size = new System.Drawing.Size(438, 238);
            this.visitsShowListBox1.TabIndex = 20;
            // 
            // backFromVisitHistoryButton1
            // 
            this.backFromVisitHistoryButton1.BackColor = System.Drawing.Color.Transparent;
            this.backFromVisitHistoryButton1.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromVisitHistoryButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromVisitHistoryButton1.FlatAppearance.BorderSize = 0;
            this.backFromVisitHistoryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromVisitHistoryButton1.Location = new System.Drawing.Point(391, 2);
            this.backFromVisitHistoryButton1.Name = "backFromVisitHistoryButton1";
            this.backFromVisitHistoryButton1.Size = new System.Drawing.Size(50, 33);
            this.backFromVisitHistoryButton1.TabIndex = 10;
            this.backFromVisitHistoryButton1.UseVisualStyleBackColor = false;
            this.backFromVisitHistoryButton1.Click += new System.EventHandler(this.backFromVisitHistoryButton1_Click);
            // 
            // backFromClientInfoButton4
            // 
            this.backFromClientInfoButton4.BackColor = System.Drawing.Color.White;
            this.backFromClientInfoButton4.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromClientInfoButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromClientInfoButton4.FlatAppearance.BorderSize = 0;
            this.backFromClientInfoButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromClientInfoButton4.Location = new System.Drawing.Point(400, 4);
            this.backFromClientInfoButton4.Name = "backFromClientInfoButton4";
            this.backFromClientInfoButton4.Size = new System.Drawing.Size(50, 33);
            this.backFromClientInfoButton4.TabIndex = 9;
            this.backFromClientInfoButton4.UseVisualStyleBackColor = false;
            this.backFromClientInfoButton4.Click += new System.EventHandler(this.backFromClientInfoButton4_Click);
            // 
            // selectInvidialClassButton2
            // 
            this.selectInvidialClassButton2.Location = new System.Drawing.Point(199, 252);
            this.selectInvidialClassButton2.Name = "selectInvidialClassButton2";
            this.selectInvidialClassButton2.Size = new System.Drawing.Size(249, 23);
            this.selectInvidialClassButton2.TabIndex = 18;
            this.selectInvidialClassButton2.Text = "выбрать";
            this.selectInvidialClassButton2.UseVisualStyleBackColor = true;
            this.selectInvidialClassButton2.Click += new System.EventHandler(this.selectInvidialClassButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.analysisPanel4);
            this.Controls.Add(this.individualClassesPanel2);
            this.Controls.Add(this.visitHistoryPanel6);
            this.Controls.Add(this.staffPanel3);
            this.Controls.Add(this.clientsButton2);
            this.Controls.Add(this.staffButton3);
            this.Controls.Add(this.analysButton4);
            this.Controls.Add(this.scheduleButton1);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.schedulePanel1);
            this.Controls.Add(this.clientsPanel2);
            this.Name = "MainForm";
            this.Text = " XFIT";
            this.schedulePanel1.ResumeLayout(false);
            this.schedulePanel1.PerformLayout();
            this.clientsPanel2.ResumeLayout(false);
            this.clientsPanel2.PerformLayout();
            this.showClientsPanel1.ResumeLayout(false);
            this.showClientsPanel1.PerformLayout();
            this.newClientPanel2.ResumeLayout(false);
            this.newClientPanel2.PerformLayout();
            this.clientInfoPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.staffPanel3.ResumeLayout(false);
            this.staffPanel3.PerformLayout();
            this.searchStaffPanel1.ResumeLayout(false);
            this.searchStaffPanel1.PerformLayout();
            this.visitHistoryPanel6.ResumeLayout(false);
            this.individualClassesPanel2.ResumeLayout(false);
            this.individualClassesPanel2.PerformLayout();
            this.analysisPanel4.ResumeLayout(false);
            this.analysisPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel1;
        private Label titleScheduleLabel1;
        private MonthCalendar monthCalendar1;
        private Button scheduleButton1;
        private Button analysButton4;
        private Button staffButton3;
        private Button clientsButton2;
        private Label dateScheduleLabel2;
        private Panel schedulePanel1;
        private Panel clientsPanel2;
        private TextBox searchClientsTextBox;
        private Button createClientsButton1;
        private Label titleClientsLabel1;
        private Panel newClientPanel2;
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
        private Label classesRestLabel5;
        private Button visitHistoryButton1;
        private Label heightLabel4;
        private Label weightLabel3;
        private Label birthDateLabel2;
        private Label clientNameLabel1;
        private Panel staffPanel3;
        private TextBox searchStaffTextBox1;
        private Label staffLabel1;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel splitter;
        private Button backFromClientInfoButton4;
        private Panel visitHistoryPanel6;
        private Label clientNameLabel2;
        private Button backFromVisitHistoryButton1;
        private Panel individualClassesPanel2;
        private MonthCalendar monthCalendar2;
        private Label invidualClassesLabel2;
        private Label invidualClassesLabel1;
        private Button employeeInfoButton1;
        private Panel searchStaffPanel1;
        private Panel analysisPanel4;
        private Label analysisLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label incomeLabel3;
        private Label clientCountLabel2;
        private ListBox timesListBox2;
        private ListBox typesOfClassesListBox1;
        private Button signUpToGroupClassButton1;
        private ListBox searchStaffResultListBox1;
        private Button selectEmployeeButton1;
        private ListBox individualClassesListBox2;
        private ListBox searchResultsClientsListBox1;
        private Button deleteClientButton3;
        private Button chooseClientButton2;
        private ListBox visitsShowListBox1;
        private Button selectInvidialClassButton2;
    }
}