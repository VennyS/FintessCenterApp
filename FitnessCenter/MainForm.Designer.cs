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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.titleClientsLabel1 = new System.Windows.Forms.Label();
            this.clientInfoPanel3 = new System.Windows.Forms.Panel();
            this.backFromClientInfoButton4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addClasseButton3 = new System.Windows.Forms.Button();
            this.signUpButton2 = new System.Windows.Forms.Button();
            this.classesRestLabel5 = new System.Windows.Forms.Label();
            this.visitHistoryButton1 = new System.Windows.Forms.Button();
            this.heightLabel4 = new System.Windows.Forms.Label();
            this.weightLabel3 = new System.Windows.Forms.Label();
            this.birthDateLabel2 = new System.Windows.Forms.Label();
            this.clientNameLabel1 = new System.Windows.Forms.Label();
            this.showClientsPanel1 = new System.Windows.Forms.Panel();
            this.createClientsButton = new System.Windows.Forms.Button();
            this.searchResultsClientsPanel1 = new System.Windows.Forms.Panel();
            this.notFoundClientsLabel1 = new System.Windows.Forms.Label();
            this.searchClientsTextBox = new System.Windows.Forms.TextBox();
            this.newClientPanel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backCreatingClientButton2 = new System.Windows.Forms.Button();
            this.newClientButton1 = new System.Windows.Forms.Button();
            this.heigthTextBox4 = new System.Windows.Forms.TextBox();
            this.weigthTextBox3 = new System.Windows.Forms.TextBox();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.newClientLabel2 = new System.Windows.Forms.Label();
            this.staffPanel3 = new System.Windows.Forms.Panel();
            this.staffLabel1 = new System.Windows.Forms.Label();
            this.searchResultsStaffPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchStaffTextBox1 = new System.Windows.Forms.TextBox();
            this.abonementsPanel4 = new System.Windows.Forms.Panel();
            this.backFromAbonementsButton4 = new System.Windows.Forms.Button();
            this.Variant3AbonementButton3 = new System.Windows.Forms.Button();
            this.Variant2AbonementButton2 = new System.Windows.Forms.Button();
            this.Variant1AbonementButton1 = new System.Windows.Forms.Button();
            this.abonementsLabel1 = new System.Windows.Forms.Label();
            this.choosedPlanPanel5 = new System.Windows.Forms.Panel();
            this.acceptPlanButton3 = new System.Windows.Forms.Button();
            this.backFromChosedPlanButton3 = new System.Windows.Forms.Button();
            this.choosedPlanButton1 = new System.Windows.Forms.Button();
            this.choosedPlanLabel1 = new System.Windows.Forms.Label();
            this.visitHistoryPanel6 = new System.Windows.Forms.Panel();
            this.visitsShowPanel1 = new System.Windows.Forms.Panel();
            this.notFoundVisitsLabel1 = new System.Windows.Forms.Label();
            this.clientNameLabel2 = new System.Windows.Forms.Label();
            this.backFromVisitHistoryButton1 = new System.Windows.Forms.Button();
            this.succesRegistrationSchedulePanel2 = new System.Windows.Forms.Panel();
            this.backFromSuccesPanelButton1 = new System.Windows.Forms.Button();
            this.succesLabel1 = new System.Windows.Forms.Label();
            this.selectClassTypePanel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.classTypeLabel1 = new System.Windows.Forms.Label();
            this.selectGroupClassButton1 = new System.Windows.Forms.Button();
            this.selectPersonalClassButton2 = new System.Windows.Forms.Button();
            this.schedulePanel1.SuspendLayout();
            this.clientsPanel2.SuspendLayout();
            this.clientInfoPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.showClientsPanel1.SuspendLayout();
            this.searchResultsClientsPanel1.SuspendLayout();
            this.newClientPanel2.SuspendLayout();
            this.staffPanel3.SuspendLayout();
            this.searchResultsStaffPanel1.SuspendLayout();
            this.abonementsPanel4.SuspendLayout();
            this.choosedPlanPanel5.SuspendLayout();
            this.visitHistoryPanel6.SuspendLayout();
            this.visitsShowPanel1.SuspendLayout();
            this.succesRegistrationSchedulePanel2.SuspendLayout();
            this.selectClassTypePanel7.SuspendLayout();
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
            this.schedulePanel1.Location = new System.Drawing.Point(710, 21);
            this.schedulePanel1.Name = "schedulePanel1";
            this.schedulePanel1.Size = new System.Drawing.Size(474, 320);
            this.schedulePanel1.TabIndex = 13;
            // 
            // clientsPanel2
            // 
            this.clientsPanel2.Controls.Add(this.titleClientsLabel1);
            this.clientsPanel2.Controls.Add(this.clientInfoPanel3);
            this.clientsPanel2.Controls.Add(this.showClientsPanel1);
            this.clientsPanel2.Controls.Add(this.newClientPanel2);
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
            this.titleClientsLabel1.Size = new System.Drawing.Size(63, 16);
            this.titleClientsLabel1.TabIndex = 3;
            this.titleClientsLabel1.Text = "Клиенты";
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
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Посещения";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(4, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Посещения";
            series2.LegendText = "Посещения";
            series2.Name = "Посещения";
            this.chart1.Series.Add(series2);
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
            this.classesRestLabel5.Location = new System.Drawing.Point(283, 117);
            this.classesRestLabel5.Name = "classesRestLabel5";
            this.classesRestLabel5.Size = new System.Drawing.Size(162, 20);
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
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 22);
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
            // abonementsPanel4
            // 
            this.abonementsPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.abonementsPanel4.Controls.Add(this.backFromAbonementsButton4);
            this.abonementsPanel4.Controls.Add(this.Variant3AbonementButton3);
            this.abonementsPanel4.Controls.Add(this.Variant2AbonementButton2);
            this.abonementsPanel4.Controls.Add(this.Variant1AbonementButton1);
            this.abonementsPanel4.Controls.Add(this.abonementsLabel1);
            this.abonementsPanel4.Location = new System.Drawing.Point(1244, 302);
            this.abonementsPanel4.Name = "abonementsPanel4";
            this.abonementsPanel4.Size = new System.Drawing.Size(437, 136);
            this.abonementsPanel4.TabIndex = 17;
            this.abonementsPanel4.Visible = false;
            // 
            // backFromAbonementsButton4
            // 
            this.backFromAbonementsButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.backFromAbonementsButton4.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromAbonementsButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromAbonementsButton4.FlatAppearance.BorderSize = 0;
            this.backFromAbonementsButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromAbonementsButton4.Location = new System.Drawing.Point(3, 3);
            this.backFromAbonementsButton4.Name = "backFromAbonementsButton4";
            this.backFromAbonementsButton4.Size = new System.Drawing.Size(50, 33);
            this.backFromAbonementsButton4.TabIndex = 10;
            this.backFromAbonementsButton4.UseVisualStyleBackColor = false;
            this.backFromAbonementsButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // Variant3AbonementButton3
            // 
            this.Variant3AbonementButton3.Location = new System.Drawing.Point(107, 100);
            this.Variant3AbonementButton3.Name = "Variant3AbonementButton3";
            this.Variant3AbonementButton3.Size = new System.Drawing.Size(222, 23);
            this.Variant3AbonementButton3.TabIndex = 3;
            this.Variant3AbonementButton3.Text = "16 занятий: 2800₽";
            this.Variant3AbonementButton3.UseVisualStyleBackColor = true;
            this.Variant3AbonementButton3.Click += new System.EventHandler(this.Variant3AbonementButton3_Click);
            // 
            // Variant2AbonementButton2
            // 
            this.Variant2AbonementButton2.Location = new System.Drawing.Point(107, 68);
            this.Variant2AbonementButton2.Name = "Variant2AbonementButton2";
            this.Variant2AbonementButton2.Size = new System.Drawing.Size(222, 23);
            this.Variant2AbonementButton2.TabIndex = 2;
            this.Variant2AbonementButton2.Text = "12 занятий: 2200₽";
            this.Variant2AbonementButton2.UseVisualStyleBackColor = true;
            this.Variant2AbonementButton2.Click += new System.EventHandler(this.Variant2AbonementButton2_Click);
            // 
            // Variant1AbonementButton1
            // 
            this.Variant1AbonementButton1.Location = new System.Drawing.Point(107, 37);
            this.Variant1AbonementButton1.Name = "Variant1AbonementButton1";
            this.Variant1AbonementButton1.Size = new System.Drawing.Size(222, 23);
            this.Variant1AbonementButton1.TabIndex = 1;
            this.Variant1AbonementButton1.Text = "8 занятий: 1600₽";
            this.Variant1AbonementButton1.UseVisualStyleBackColor = true;
            this.Variant1AbonementButton1.Click += new System.EventHandler(this.Variant1AbonementButton1_Click);
            // 
            // abonementsLabel1
            // 
            this.abonementsLabel1.AutoSize = true;
            this.abonementsLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.abonementsLabel1.Location = new System.Drawing.Point(174, 6);
            this.abonementsLabel1.Name = "abonementsLabel1";
            this.abonementsLabel1.Size = new System.Drawing.Size(89, 16);
            this.abonementsLabel1.TabIndex = 0;
            this.abonementsLabel1.Text = "Абонементы";
            // 
            // choosedPlanPanel5
            // 
            this.choosedPlanPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.choosedPlanPanel5.Controls.Add(this.acceptPlanButton3);
            this.choosedPlanPanel5.Controls.Add(this.backFromChosedPlanButton3);
            this.choosedPlanPanel5.Controls.Add(this.choosedPlanButton1);
            this.choosedPlanPanel5.Controls.Add(this.choosedPlanLabel1);
            this.choosedPlanPanel5.Location = new System.Drawing.Point(1244, 452);
            this.choosedPlanPanel5.Name = "choosedPlanPanel5";
            this.choosedPlanPanel5.Size = new System.Drawing.Size(437, 136);
            this.choosedPlanPanel5.TabIndex = 18;
            this.choosedPlanPanel5.Visible = false;
            // 
            // acceptPlanButton3
            // 
            this.acceptPlanButton3.Location = new System.Drawing.Point(157, 87);
            this.acceptPlanButton3.Name = "acceptPlanButton3";
            this.acceptPlanButton3.Size = new System.Drawing.Size(119, 32);
            this.acceptPlanButton3.TabIndex = 11;
            this.acceptPlanButton3.Text = "подтвердить";
            this.acceptPlanButton3.UseVisualStyleBackColor = true;
            this.acceptPlanButton3.Click += new System.EventHandler(this.acceptPlanButton3_Click);
            // 
            // backFromChosedPlanButton3
            // 
            this.backFromChosedPlanButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.backFromChosedPlanButton3.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromChosedPlanButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromChosedPlanButton3.FlatAppearance.BorderSize = 0;
            this.backFromChosedPlanButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromChosedPlanButton3.Location = new System.Drawing.Point(3, 3);
            this.backFromChosedPlanButton3.Name = "backFromChosedPlanButton3";
            this.backFromChosedPlanButton3.Size = new System.Drawing.Size(50, 33);
            this.backFromChosedPlanButton3.TabIndex = 10;
            this.backFromChosedPlanButton3.UseVisualStyleBackColor = false;
            this.backFromChosedPlanButton3.Click += new System.EventHandler(this.backFromChosedPlanButton3_Click);
            // 
            // choosedPlanButton1
            // 
            this.choosedPlanButton1.Location = new System.Drawing.Point(107, 37);
            this.choosedPlanButton1.Name = "choosedPlanButton1";
            this.choosedPlanButton1.Size = new System.Drawing.Size(222, 35);
            this.choosedPlanButton1.TabIndex = 1;
            this.choosedPlanButton1.Text = "8 занятий: 1600₽";
            this.choosedPlanButton1.UseVisualStyleBackColor = true;
            // 
            // choosedPlanLabel1
            // 
            this.choosedPlanLabel1.AutoSize = true;
            this.choosedPlanLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.choosedPlanLabel1.Location = new System.Drawing.Point(174, 6);
            this.choosedPlanLabel1.Name = "choosedPlanLabel1";
            this.choosedPlanLabel1.Size = new System.Drawing.Size(89, 16);
            this.choosedPlanLabel1.TabIndex = 0;
            this.choosedPlanLabel1.Text = "Абонементы";
            // 
            // visitHistoryPanel6
            // 
            this.visitHistoryPanel6.Controls.Add(this.visitsShowPanel1);
            this.visitHistoryPanel6.Controls.Add(this.clientNameLabel2);
            this.visitHistoryPanel6.Controls.Add(this.backFromVisitHistoryButton1);
            this.visitHistoryPanel6.Location = new System.Drawing.Point(1247, 12);
            this.visitHistoryPanel6.Name = "visitHistoryPanel6";
            this.visitHistoryPanel6.Size = new System.Drawing.Size(456, 281);
            this.visitHistoryPanel6.TabIndex = 19;
            this.visitHistoryPanel6.Visible = false;
            // 
            // visitsShowPanel1
            // 
            this.visitsShowPanel1.Controls.Add(this.notFoundVisitsLabel1);
            this.visitsShowPanel1.Location = new System.Drawing.Point(15, 39);
            this.visitsShowPanel1.Name = "visitsShowPanel1";
            this.visitsShowPanel1.Size = new System.Drawing.Size(426, 229);
            this.visitsShowPanel1.TabIndex = 11;
            // 
            // notFoundVisitsLabel1
            // 
            this.notFoundVisitsLabel1.AutoSize = true;
            this.notFoundVisitsLabel1.Location = new System.Drawing.Point(158, 11);
            this.notFoundVisitsLabel1.Name = "notFoundVisitsLabel1";
            this.notFoundVisitsLabel1.Size = new System.Drawing.Size(141, 16);
            this.notFoundVisitsLabel1.TabIndex = 0;
            this.notFoundVisitsLabel1.Text = "Пока нет посещений";
            // 
            // clientNameLabel2
            // 
            this.clientNameLabel2.Location = new System.Drawing.Point(12, 9);
            this.clientNameLabel2.Name = "clientNameLabel2";
            this.clientNameLabel2.Size = new System.Drawing.Size(147, 20);
            this.clientNameLabel2.TabIndex = 10;
            this.clientNameLabel2.Text = "Имя клиента";
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
            // succesRegistrationSchedulePanel2
            // 
            this.succesRegistrationSchedulePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.succesRegistrationSchedulePanel2.Controls.Add(this.backFromSuccesPanelButton1);
            this.succesRegistrationSchedulePanel2.Controls.Add(this.succesLabel1);
            this.succesRegistrationSchedulePanel2.Location = new System.Drawing.Point(46, 314);
            this.succesRegistrationSchedulePanel2.Name = "succesRegistrationSchedulePanel2";
            this.succesRegistrationSchedulePanel2.Size = new System.Drawing.Size(331, 124);
            this.succesRegistrationSchedulePanel2.TabIndex = 19;
            this.succesRegistrationSchedulePanel2.Visible = false;
            // 
            // backFromSuccesPanelButton1
            // 
            this.backFromSuccesPanelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.backFromSuccesPanelButton1.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.backFromSuccesPanelButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backFromSuccesPanelButton1.FlatAppearance.BorderSize = 0;
            this.backFromSuccesPanelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFromSuccesPanelButton1.Location = new System.Drawing.Point(-5, 3);
            this.backFromSuccesPanelButton1.Name = "backFromSuccesPanelButton1";
            this.backFromSuccesPanelButton1.Size = new System.Drawing.Size(50, 33);
            this.backFromSuccesPanelButton1.TabIndex = 10;
            this.backFromSuccesPanelButton1.UseVisualStyleBackColor = false;
            this.backFromSuccesPanelButton1.Click += new System.EventHandler(this.backFromSuccesPanelButton1_Click);
            // 
            // succesLabel1
            // 
            this.succesLabel1.AutoSize = true;
            this.succesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succesLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.succesLabel1.Location = new System.Drawing.Point(47, 23);
            this.succesLabel1.Name = "succesLabel1";
            this.succesLabel1.Size = new System.Drawing.Size(216, 88);
            this.succesLabel1.TabIndex = 0;
            this.succesLabel1.Text = "Имя, успешно записана!\r\n31.04.24 18:00\r\nНаправление: силовая\r\n\r\n";
            // 
            // selectClassTypePanel7
            // 
            this.selectClassTypePanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.selectClassTypePanel7.Controls.Add(this.selectPersonalClassButton2);
            this.selectClassTypePanel7.Controls.Add(this.selectGroupClassButton1);
            this.selectClassTypePanel7.Controls.Add(this.button2);
            this.selectClassTypePanel7.Controls.Add(this.classTypeLabel1);
            this.selectClassTypePanel7.Location = new System.Drawing.Point(1244, 594);
            this.selectClassTypePanel7.Name = "selectClassTypePanel7";
            this.selectClassTypePanel7.Size = new System.Drawing.Size(437, 93);
            this.selectClassTypePanel7.TabIndex = 19;
            this.selectClassTypePanel7.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(93)))), ((int)(((byte)(88)))));
            this.button2.BackgroundImage = global::FitnessCenter.Properties.Resources.back_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 33);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // classTypeLabel1
            // 
            this.classTypeLabel1.AutoSize = true;
            this.classTypeLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.classTypeLabel1.Location = new System.Drawing.Point(140, 3);
            this.classTypeLabel1.Name = "classTypeLabel1";
            this.classTypeLabel1.Size = new System.Drawing.Size(145, 16);
            this.classTypeLabel1.TabIndex = 0;
            this.classTypeLabel1.Text = "Записать на занятие";
            // 
            // selectGroupClassButton1
            // 
            this.selectGroupClassButton1.Location = new System.Drawing.Point(78, 43);
            this.selectGroupClassButton1.Name = "selectGroupClassButton1";
            this.selectGroupClassButton1.Size = new System.Drawing.Size(130, 28);
            this.selectGroupClassButton1.TabIndex = 11;
            this.selectGroupClassButton1.Text = "Групповое";
            this.selectGroupClassButton1.UseVisualStyleBackColor = true;
            this.selectGroupClassButton1.Click += new System.EventHandler(this.selectGroupClassButton1_Click);
            // 
            // selectPersonalClassButton2
            // 
            this.selectPersonalClassButton2.Location = new System.Drawing.Point(234, 43);
            this.selectPersonalClassButton2.Name = "selectPersonalClassButton2";
            this.selectPersonalClassButton2.Size = new System.Drawing.Size(131, 28);
            this.selectPersonalClassButton2.TabIndex = 12;
            this.selectPersonalClassButton2.Text = "Индивидуальное";
            this.selectPersonalClassButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 720);
            this.Controls.Add(this.selectClassTypePanel7);
            this.Controls.Add(this.succesRegistrationSchedulePanel2);
            this.Controls.Add(this.visitHistoryPanel6);
            this.Controls.Add(this.choosedPlanPanel5);
            this.Controls.Add(this.abonementsPanel4);
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
            this.clientInfoPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.showClientsPanel1.ResumeLayout(false);
            this.showClientsPanel1.PerformLayout();
            this.searchResultsClientsPanel1.ResumeLayout(false);
            this.searchResultsClientsPanel1.PerformLayout();
            this.newClientPanel2.ResumeLayout(false);
            this.newClientPanel2.PerformLayout();
            this.staffPanel3.ResumeLayout(false);
            this.staffPanel3.PerformLayout();
            this.searchResultsStaffPanel1.ResumeLayout(false);
            this.searchResultsStaffPanel1.PerformLayout();
            this.abonementsPanel4.ResumeLayout(false);
            this.abonementsPanel4.PerformLayout();
            this.choosedPlanPanel5.ResumeLayout(false);
            this.choosedPlanPanel5.PerformLayout();
            this.visitHistoryPanel6.ResumeLayout(false);
            this.visitsShowPanel1.ResumeLayout(false);
            this.visitsShowPanel1.PerformLayout();
            this.succesRegistrationSchedulePanel2.ResumeLayout(false);
            this.succesRegistrationSchedulePanel2.PerformLayout();
            this.selectClassTypePanel7.ResumeLayout(false);
            this.selectClassTypePanel7.PerformLayout();
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
        private Panel availableSchedulePanel1;
        private Label dateScheduleLabel2;
        private Panel schedulePanel1;
        private Panel clientsPanel2;
        private TextBox searchClientsTextBox;
        private Button createClientsButton;
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
        private Panel searchResultsClientsPanel1;
        private Label notFoundClientsLabel1;
        private Label clientNameLabel1;
        private Panel staffPanel3;
        private Panel searchResultsStaffPanel1;
        private Label label1;
        private TextBox searchStaffTextBox1;
        private Label staffLabel1;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel splitter;
        private Button backFromClientInfoButton4;
        private Panel abonementsPanel4;
        private Label abonementsLabel1;
        private Button Variant3AbonementButton3;
        private Button Variant2AbonementButton2;
        private Button Variant1AbonementButton1;
        private Button backFromAbonementsButton4;
        private Panel choosedPlanPanel5;
        private Button acceptPlanButton3;
        private Button backFromChosedPlanButton3;
        private Button choosedPlanButton1;
        private Label choosedPlanLabel1;
        private Panel visitHistoryPanel6;
        private Panel visitsShowPanel1;
        private Label clientNameLabel2;
        private Button backFromVisitHistoryButton1;
        private Label notFoundVisitsLabel1;
        private Panel succesRegistrationSchedulePanel2;
        private Button backFromSuccesPanelButton1;
        private Label succesLabel1;
        private Panel selectClassTypePanel7;
        private Button selectPersonalClassButton2;
        private Button selectGroupClassButton1;
        private Button button2;
        private Label classTypeLabel1;
    }
}