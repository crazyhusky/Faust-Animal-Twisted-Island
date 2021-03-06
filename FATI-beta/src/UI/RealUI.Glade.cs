﻿using Pango;

namespace FATI_beta.UI
{
    using Gtk;

    public class RealUI_Glade
    {
        private Gtk.Button button1;
        private Gtk.Label labelLibido;
        private Gtk.Label labelSpeed;
        private Gtk.Label labelToughness;
        private Gtk.Label labelStrenght;
        private Gtk.Label label6;
        private Gtk.Label label5;
        private Gtk.Label label4;
        private Gtk.Label label3;
        private Gtk.Label label2;
        private Gtk.Label label1;
        private Gtk.Button btnOptions;
        private Gtk.Button btnNewGame;
        private Gtk.Button btnLoad;
        private Gtk.Button btnSave;
        private Gtk.Button buttonCmd5;
        private Gtk.Button buttonCmd4;
        private Gtk.Button buttonCmd1;
        private Gtk.Button buttonCmd2;
        private Gtk.Button buttonCmd3;
        private Gtk.Button button8;
        private Gtk.Button button9;
        private Gtk.Button button7;
        private Gtk.Button button6;
        private Gtk.Button button5;
        private Gtk.Button button10;
        private Gtk.Button button4;
        private Gtk.Button button3;
        private Gtk.Button button2;
        private Gtk.Label label7;
        private Gtk.Label label11;
        private Gtk.Label label10;
        private Gtk.Label label9;
        private Gtk.Label label8;
        private Gtk.Label labelLust;
        private Gtk.Label labelHP;
        private Gtk.ProgressBar progressBarHP;
        private Gtk.ProgressBar progressBarLust;
        private Gtk.Label labelLevel;
        private Gtk.Label labelDay;
        private Gtk.Label labelHour;
        private Gtk.Label labelCoins;
        private Gtk.Label labelExp;
        private Gtk.ProgressBar progressBarExp;
        private Gtk.Layout MainStoryTextPanel;
        private Gtk.Layout ActionbuttonHolder;
        private Gtk.Button button12;
        private Gtk.Button button14;
        private Gtk.Button button11;
        private Gtk.Button button13;
        private Gtk.Button button15;
        private Gtk.Layout panel3;
        private Gtk.Layout PlayerStatsPanel;
        private Gtk.Layout AdditionalStatsPanel;
        private Gtk.Table MainActionsPanel;
        private Gtk.Layout mainPanel;
        private Gtk.TextView richTextBoxMain;
        private Gtk.TextView richTextBoxSub;
        private Pango.FontDescription defaultFontBold;
        private Pango.FontDescription defaultFontRegular;
        private Gtk.Alignment ActionPanelLocation;
        private Gtk.Window MainWindow;

        public void initComponents()
        {
            ActionPanelLocation = new Alignment(0, 1, 0, 0);
            MainWindow = new Window("Game");
            mainPanel = new Layout(null, null);
            defaultFontBold = Pango.FontDescription.FromString("Microsoft Sans Serif 10");
            defaultFontBold.Weight = Pango.Weight.Bold;
            defaultFontRegular = Pango.FontDescription.FromString("Microsoft Sans Serif 10");
            defaultFontRegular.Weight = Pango.Weight.Normal;
            labelLibido = new Label();
            labelSpeed = new Label();
            this.labelToughness = new Label();
            this.labelStrenght = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.btnOptions = new Button();

            this.btnNewGame = new Button();

            this.btnLoad = new Button();

            this.btnSave = new Button();

            this.buttonCmd5 = new Button();

            this.buttonCmd4 = new Button();
            this.buttonCmd1 = new Button();

            this.buttonCmd2 = new Button();

            this.buttonCmd3 = new Button();

            this.button8 = new Button();

            this.button9 = new Button();

            this.button7 = new Button();

            this.button6 = new Button();

            this.button5 = new Button();

            this.button10 = new Button();

            this.button4 = new Button();

            this.button3 = new Button();

            this.button2 = new Button();

            this.button1 = new Button();

            this.label11 = new Label();
            this.label10 = new Label();
            this.label9 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.labelHP = new Label();
            this.labelLust = new Label();
            this.progressBarHP = new ProgressBar();
            this.progressBarLust = new ProgressBar();
            this.labelLevel = new Label();
            this.labelDay = new Label();
            this.labelHour = new Label();
            this.labelCoins = new Label();
            this.labelExp = new Label();
            this.progressBarExp = new ProgressBar();
            this.MainStoryTextPanel = new Layout(null, null);
            this.richTextBoxMain = new TextView();
            this.ActionbuttonHolder = new Layout(null, null);
            this.button12 = new Button();
            this.button14 = new Button();
            this.button11 = new Button();
            this.button13 = new Button();
            this.button15 = new Button();
            this.panel3 = new Layout(null, null);
            this.richTextBoxSub = new TextView();
            this.PlayerStatsPanel = new Layout(null, null);
            this.AdditionalStatsPanel = new Layout(null, null);
            this.MainActionsPanel = new Table(2, 2,true);

            // 
            // labelLibido
            // 
            ////this.labelLibido.AutoSize = true;
            this.labelLibido.ModifyFont(defaultFontBold);
            // //this.labelLibido.Location = new System.Drawing.Point(93, 69);
            this.labelLibido.Name = "labelLibido";
            this.labelLibido.SetSizeRequest(16, 16);
            // //this.labelLibido.TabIndex = 9;
            this.labelLibido.Text = "0";
            // 
            // labelSpeed
            // 
            // //this.labelSpeed.AutoSize = true;
            this.labelSpeed.ModifyFont(defaultFontBold);
            // //this.labelSpeed.Location = new System.Drawing.Point(93, 47);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.SetSizeRequest(16, 16);
            ////this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "0";
            // 
            // labelToughness
            // 
            // //this.labelToughness.AutoSize = true;
            this.labelToughness.ModifyFont(defaultFontBold);
            // //this.labelToughness.Location = new System.Drawing.Point(93, 27);
            this.labelToughness.Name = "labelToughness";
            this.labelToughness.SetSizeRequest(16, 16);
            // //this.labelToughness.TabIndex = 7;
            this.labelToughness.Text = "0";
            // this.labelToughness.Click += new System.EventHandler(this.label14_Click);
            // 
            // labelStrenght
            // 
            ////this.labelStrenght.AutoSize = true;
            this.labelStrenght.ModifyFont(defaultFontBold);
            ////this.labelStrenght.Location = new System.Drawing.Point(93, 7);
            this.labelStrenght.Name = "labelStrenght";
            this.labelStrenght.SetSizeRequest(16, 16);
            ////this.labelStrenght.TabIndex = 6;
            this.labelStrenght.Text = "0";
            // 
            // label6
            // 
            // //this.label6.AutoSize = true;
            this.label6.ModifyFont(defaultFontBold);
            // //this.label6.Location = new System.Drawing.Point(200, 47);
            this.label6.Name = "label6";
            this.label6.SetSizeRequest(36, 16);
            // //this.label6.TabIndex = 5;
            this.label6.Text = "Lust";
            // 
            // label5
            // 
            // //this.label5.AutoSize = true;
            this.label5.ModifyFont(defaultFontBold);
            // //this.label5.Location = new System.Drawing.Point(200, 7);
            this.label5.Name = "label5";
            this.label5.SetSizeRequest(29, 16);
            // //this.label5.TabIndex = 4;
            this.label5.Text = "HP";
            // 
            // label4
            // 
            ////this.label4.AutoSize = true;
            this.label4.ModifyFont(defaultFontBold);
            ////this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.SetSizeRequest(51, 16);
            // //this.label4.TabIndex = 3;
            this.label4.Text = "Libido";
            // 
            // label3
            // 
            // //this.label3.AutoSize = true;
            this.label3.ModifyFont(defaultFontBold);
            // //this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.SetSizeRequest(54, 16);
            // //this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            ////this.label2.AutoSize = true;
            this.label2.ModifyFont(defaultFontBold);
            // //this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.SetSizeRequest(85, 16);
            //  //this.label2.TabIndex = 1;
            this.label2.Text = "Toughness";
            // 
            // label1
            // 
            ////this.label1.AutoSize = true;
            this.label1.ModifyFont(defaultFontBold);
            ////this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.SetSizeRequest(65, 16);
            // //this.label1.TabIndex = 0;
            this.label1.Text = "Strenght";
            // 
            // btnOptions
            // 
            ////this.btnOptions.BackColor = System.Drawing.Color.PeachPuff;
            ////this.btnOptions.FlatAppearance.BorderSize = 2;
            // //this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.ModifyFont(defaultFontBold);
            ////this.btnOptions.Location = new System.Drawing.Point(163, 3);
            //this.btnOptions.Name = "btnOptions";
            // this.btnOptions.SetSizeRequest(140, 33);
            ////this.btnOptions.TabIndex = 18;
            this.btnOptions.Label = "Options";
            ////this.btnOptions.UseVisualStyleBackColor = false;
            // this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnNewGame
            // 
            //this.btnNewGame.BackColor = System.Drawing.Color.PeachPuff;
            //this.btnNewGame.FlatAppearance.BorderSize = 2;
            //this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.ModifyFont(defaultFontBold);
            //this.btnNewGame.Location = new System.Drawing.Point(18, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.SetSizeRequest(140, 33);
            //this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Label = "New Game";
            //this.btnNewGame.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            //this.btnLoad.BackColor = System.Drawing.Color.PeachPuff;
            //this.btnLoad.FlatAppearance.BorderSize = 2;
            //this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ModifyFont(defaultFontBold);
            //this.btnLoad.Location = new System.Drawing.Point(164, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.SetSizeRequest(140, 33);
            //this.btnLoad.TabIndex = 16;
            this.btnLoad.Label = "Load";
            //this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            //this.btnSave.BackColor = System.Drawing.Color.PeachPuff;
            //this.btnSave.FlatAppearance.BorderSize = 2;
            //this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ModifyFont(defaultFontBold);
            //this.btnSave.Location = new System.Drawing.Point(18, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.SetSizeRequest(140, 33);
            //this.btnSave.TabIndex = 15;
            this.btnSave.Label = "Save";
            //this.btnSave.UseVisualStyleBackColor = false;
            // 
            // buttonCmd5
            // 
            //this.buttonCmd5.BackColor = System.Drawing.Color.PeachPuff;
            //this.buttonCmd5.FlatAppearance.BorderSize = 2;
            //this.buttonCmd5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd5.ModifyFont(defaultFontBold);
            //this.buttonCmd5.Location = new System.Drawing.Point(718, 126);
            this.buttonCmd5.Name = "buttonCmd5";
            this.buttonCmd5.SetSizeRequest(170, 34);
            //this.buttonCmd5.TabIndex = 10;
            this.buttonCmd5.Label = "buttonCmd5";
            //this.buttonCmd5.UseVisualStyleBackColor = false;
            // 
            // buttonCmd4
            // 
            //this.buttonCmd4.BackColor = System.Drawing.Color.PeachPuff;
            //this.buttonCmd4.FlatAppearance.BorderSize = 2;
            //this.buttonCmd4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd4.ModifyFont(defaultFontBold);
            //this.buttonCmd4.Location = new System.Drawing.Point(542, 126);
            this.buttonCmd4.Name = "buttonCmd4";
            this.buttonCmd4.SetSizeRequest(170, 34);
            //this.buttonCmd4.TabIndex = 11;
            this.buttonCmd4.Label = "buttonCmd4";
            //this.buttonCmd4.UseVisualStyleBackColor = false;
            // 
            // buttonCmd1
            // 
            //this.buttonCmd1.BackColor = System.Drawing.Color.PeachPuff;
            //this.buttonCmd1.FlatAppearance.BorderSize = 2;
            //this.buttonCmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd1.ModifyFont(defaultFontBold);
            //this.buttonCmd1.Location = new System.Drawing.Point(14, 126);
            this.buttonCmd1.Name = "buttonCmd1";
            this.buttonCmd1.SetSizeRequest(170, 34);
            //this.buttonCmd1.TabIndex = 14;
            this.buttonCmd1.Label = "Perks";
            //this.buttonCmd1.UseVisualStyleBackColor = false;
            // 
            // buttonCmd2
            // 
            //this.buttonCmd2.BackColor = System.Drawing.Color.PeachPuff;
            //this.buttonCmd2.FlatAppearance.BorderSize = 2;
            //this.buttonCmd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd2.ModifyFont(defaultFontBold);
            //this.buttonCmd2.Location = new System.Drawing.Point(190, 126);
            this.buttonCmd2.Name = "buttonCmd2";
            this.buttonCmd2.SetSizeRequest(170, 34);
            //this.buttonCmd2.TabIndex = 13;
            this.buttonCmd2.Label = "Inventory";
            //this.buttonCmd2.UseVisualStyleBackColor = false;
            // 
            // buttonCmd3
            // 
            //this.buttonCmd3.BackColor = System.Drawing.Color.PeachPuff;
            //this.buttonCmd3.FlatAppearance.BorderSize = 2;
            //this.buttonCmd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd3.ModifyFont(defaultFontBold);
            //this.buttonCmd3.Location = new System.Drawing.Point(366, 126);
            this.buttonCmd3.Name = "buttonCmd3";
            this.buttonCmd3.SetSizeRequest(170, 34);
            //this.buttonCmd3.TabIndex = 12;
            this.buttonCmd3.Label = "buttonCmd3";
            //this.buttonCmd3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            //this.button8.BackColor = System.Drawing.Color.Peru;
            //this.button8.FlatAppearance.BorderSize = 2;
            //this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ModifyFont(defaultFontBold);
            //this.button8.Location = new System.Drawing.Point(366, 41);
            this.button8.Name = "button8";
            this.button8.SetSizeRequest(170, 34);
            //this.button8.TabIndex = 7;
            this.button8.Label = "button8";
            //this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            //this.button9.BackColor = System.Drawing.Color.Peru;
            //this.button9.FlatAppearance.BorderSize = 2;
            //this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ModifyFont(defaultFontBold);
            //this.button9.Location = new System.Drawing.Point(542, 41);
            this.button9.Name = "button9";
            this.button9.SetSizeRequest(170, 34);
            //this.button9.TabIndex = 6;
            this.button9.Label = "button9";
            //this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            //this.button7.BackColor = System.Drawing.Color.Peru;
            //this.button7.FlatAppearance.BorderSize = 2;
            //this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ModifyFont(defaultFontBold);
            //this.button7.Location = new System.Drawing.Point(190, 41);
            this.button7.Name = "button7";
            this.button7.SetSizeRequest(170, 34);
            //this.button7.TabIndex = 8;
            this.button7.Label = "button7";
            //this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            //this.button6.BackColor = System.Drawing.Color.Peru;
            //this.button6.FlatAppearance.BorderSize = 2;
            //this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ModifyFont(defaultFontBold);
            //this.button6.Location = new System.Drawing.Point(14, 41);
            this.button6.Name = "button6";
            this.button6.SetSizeRequest(170, 34);
            //this.button6.TabIndex = 9;
            this.button6.Label = "button6";
            //this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            //this.button5.BackColor = System.Drawing.Color.Peru;
            //this.button5.FlatAppearance.BorderSize = 2;
            //this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ModifyFont(defaultFontBold);
            //this.button5.Location = new System.Drawing.Point(718, 4);
            this.button5.Name = "button5";
            this.button5.SetSizeRequest(170, 34);
            //this.button5.TabIndex = 4;
            this.button5.Label = "button5";
            //this.button5.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            //this.button10.BackColor = System.Drawing.Color.Peru;
            //this.button10.FlatAppearance.BorderSize = 2;
            //this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ModifyFont(defaultFontBold);
            //this.button10.Location = new System.Drawing.Point(718, 41);
            this.button10.Name = "button10";
            this.button10.SetSizeRequest(170, 34);
            //this.button10.TabIndex = 5;
            this.button10.Label = "button10";
            //this.button10.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            //this.button4.BackColor = System.Drawing.Color.Peru;
            //this.button4.FlatAppearance.BorderSize = 2;
            //this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ModifyFont(defaultFontBold);
            //this.button4.Location = new System.Drawing.Point(542, 4);
            this.button4.Name = "button4";
            this.button4.SetSizeRequest(170, 34);
            //this.button4.TabIndex = 3;
            this.button4.Label = "button4";
            //this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            //this.button3.BackColor = System.Drawing.Color.Peru;
            //this.button3.FlatAppearance.BorderSize = 2;
            //this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ModifyFont(defaultFontBold);
            //this.button3.Location = new System.Drawing.Point(366, 4);
            this.button3.Name = "button3";
            this.button3.SetSizeRequest(170, 34);
            //this.button3.TabIndex = 2;
            this.button3.Label = "button3";
            //this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            //this.button2.BackColor = System.Drawing.Color.Peru;
            //this.button2.FlatAppearance.BorderSize = 2;
            //this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ModifyFont(defaultFontBold);
            //this.button2.Location = new System.Drawing.Point(190, 4);
            this.button2.Name = "button2";
            this.button2.SetSizeRequest(170, 34);
            //this.button2.TabIndex = 1;
            this.button2.Label = "button2";
            //this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            //this.button1.BackColor = System.Drawing.Color.Peru;
            //this.button1.FlatAppearance.BorderSize = 2;
            //this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ModifyFont(defaultFontBold);
            //this.button1.Location = new System.Drawing.Point(14, 4);
            this.button1.Name = "button1";
            this.button1.SetSizeRequest(170, 34);
            //this.button1.TabIndex = 0;
            this.button1.Label = "button1";
            //this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            //this.label11.AutoSize = true;
            this.label11.ModifyFont(defaultFontBold);
            //this.label11.Location = new System.Drawing.Point(172, 38);
            this.label11.Name = "label11";
            this.label11.SetSizeRequest(47, 16);
            //this.label11.TabIndex = 10;
            this.label11.Text = "Coins";
            // 
            // label10
            // 
            //this.label10.AutoSize = true;
            this.label10.ModifyFont(defaultFontBold);
            //this.label10.Location = new System.Drawing.Point(241, 12);
            this.label10.Name = "label10";
            this.label10.SetSizeRequest(41, 16);
            //this.label10.TabIndex = 9;
            this.label10.Text = "Hour";
            // 
            // label9
            // 
            //this.label9.AutoSize = true;
            this.label9.ModifyFont(defaultFontBold);
            //this.label9.Location = new System.Drawing.Point(172, 12);
            this.label9.Name = "label9";
            this.label9.SetSizeRequest(36, 16);
            //this.label9.TabIndex = 8;
            this.label9.Text = "Day";
            // 
            // label8
            // 
            //this.label8.AutoSize = true;
            this.label8.ModifyFont(defaultFontBold);
            //this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Name = "label8";
            this.label8.SetSizeRequest(34, 16);
            //this.label8.TabIndex = 7;
            this.label8.Text = "Exp";
            // 
            // label7
            // 
            //this.label7.AutoSize = true;
            this.label7.ModifyFont(defaultFontBold);
            //this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.SetSizeRequest(46, 16);
            //this.label7.TabIndex = 6;
            this.label7.Text = "Level";
            // 
            // labelHP
            // 
            //this.labelHP.AutoSize = true;
            this.labelHP.ModifyFont(defaultFontBold);
            //this.labelHP.Location = new System.Drawing.Point(254, 7);
            this.labelHP.Name = "labelHP";
            this.labelHP.SetSizeRequest(16, 16);
            //this.labelHP.TabIndex = 10;
            this.labelHP.Text = "0";
            // 
            // labelLust
            // 
            //this.labelLust.AutoSize = true;
            this.labelLust.ModifyFont(defaultFontBold);
            //this.labelLust.Location = new System.Drawing.Point(254, 47);
            this.labelLust.Name = "labelLust";
            this.labelLust.SetSizeRequest(16, 16);
            //this.labelLust.TabIndex = 11;
            this.labelLust.Text = "0";
            // 
            // progressBarHP
            // 
            //this.progressBarHP.ForeColor = System.Drawing.Color.Purple;
            //this.progressBarHP.Location = new System.Drawing.Point(203, 26);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.SetSizeRequest(100, 10);
            //this.progressBarHP.TabIndex = 12;
            // 
            // progressBarLust
            // 
            //this.progressBarLust.ForeColor = System.Drawing.Color.DeepPink;
            //this.progressBarLust.Location = new System.Drawing.Point(203, 69);
            this.progressBarLust.Name = "progressBarLust";
            this.progressBarLust.SetSizeRequest(100, 10);
            //this.progressBarLust.TabIndex = 13;
            // 
            // labelLevel
            // 
            //this.labelLevel.AutoSize = true;
            this.labelLevel.ModifyFont(defaultFontBold);
            //this.labelLevel.Location = new System.Drawing.Point(58, 12);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.SetSizeRequest(16, 16);
            //this.labelLevel.TabIndex = 14;
            this.labelLevel.Text = "0";
            // 
            // labelDay
            // 
            //this.labelDay.AutoSize = true;
            this.labelDay.ModifyFont(defaultFontBold);
            //this.labelDay.Location = new System.Drawing.Point(214, 12);
            this.labelDay.Name = "labelDay";
            this.labelDay.SetSizeRequest(16, 16);
            //this.labelDay.TabIndex = 15;
            this.labelDay.Text = "0";
            // 
            // labelHour
            // 
            //this.labelHour.AutoSize = true;
            this.labelHour.ModifyFont(defaultFontBold);
            //this.labelHour.Location = new System.Drawing.Point(290, 12);
            this.labelHour.Name = "labelHour";
            this.labelHour.SetSizeRequest(16, 16);
            //this.labelHour.TabIndex = 16;
            this.labelHour.Text = "0";
            // 
            // labelCoins
            // 
            //this.labelCoins.AutoSize = true;
            this.labelCoins.ModifyFont(defaultFontBold);
            //this.labelCoins.Location = new System.Drawing.Point(241, 38);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.SetSizeRequest(16, 16);
            //this.labelCoins.TabIndex = 17;
            this.labelCoins.Text = "0";
            // 
            // labelExp
            // 
            //this.labelExp.AutoSize = true;
            this.labelExp.ModifyFont(defaultFontBold);
            //this.labelExp.Location = new System.Drawing.Point(44, 38);
            this.labelExp.Name = "labelExp";
            this.labelExp.SetSizeRequest(16, 16);
            //this.labelExp.TabIndex = 18;
            this.labelExp.Text = "0";
            // 
            // progressBarExp
            // 
            //this.progressBarExp.ForeColor = System.Drawing.Color.Lime;
            //this.progressBarExp.Location = new System.Drawing.Point(65, 44);
            this.progressBarExp.Name = "progressBarExp";
            this.progressBarExp.SetSizeRequest(95, 10);
            //this.progressBarExp.TabIndex = 14;
            // 
            // MainStoryTextPanel
            // 
            //this.MainStoryTextPanel.BackColor = System.Drawing.Color.MediumOrchid;
            //this.MainStoryTextPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainStoryTextPanel.Add(this.richTextBoxMain);
            //this.MainStoryTextPanel.Location = new System.Drawing.Point(346, 10);
            this.MainStoryTextPanel.Name = "MainStoryTextPanel";
            this.MainStoryTextPanel.SetSizeRequest(906, 495);
            //this.MainStoryTextPanel.TabIndex = 4;
            // 
            // richTextBoxMain
            // 
            //this.richTextBoxMain.BackColor = System.Drawing.Color.Thistle;
            this.richTextBoxMain.ModifyFont(FontDescription.FromString("Microsoft Sans Serif 10"));
            //this.richTextBoxMain.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.SetSizeRequest(898, 487);
            //this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Buffer.Text = "";
            // 
            // panel2
            // 
            //this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            //this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionbuttonHolder.Add(this.button12);
            this.ActionbuttonHolder.Add(this.button14);
            this.ActionbuttonHolder.Add(this.button11);
            this.ActionbuttonHolder.Add(this.button13);
            this.ActionbuttonHolder.Add(this.button15);
            this.ActionbuttonHolder.Add(this.button1);
            this.ActionbuttonHolder.Add(this.button3);
            this.ActionbuttonHolder.Add(this.button7);
            this.ActionbuttonHolder.Add(this.buttonCmd5);
            this.ActionbuttonHolder.Add(this.button9);
            this.ActionbuttonHolder.Add(this.button6);
            this.ActionbuttonHolder.Add(this.buttonCmd4);
            this.ActionbuttonHolder.Add(this.button8);
            this.ActionbuttonHolder.Add(this.button2);
            this.ActionbuttonHolder.Add(this.button5);
            this.ActionbuttonHolder.Add(this.buttonCmd1);
            this.ActionbuttonHolder.Add(this.buttonCmd3);
            this.ActionbuttonHolder.Add(this.button4);
            this.ActionbuttonHolder.Add(this.button10);
            this.ActionbuttonHolder.Add(this.buttonCmd2);
            //this.panel2.Location = new System.Drawing.Point(346, 509);
            this.ActionbuttonHolder.Name = "ActionButtonHolder";
            this.ActionbuttonHolder.SetSizeRequest(906, 167);
            //this.panel2.TabIndex = 5;
            //this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button12
            // 
            //this.button12.BackColor = System.Drawing.Color.Peru;
            //this.button12.FlatAppearance.BorderSize = 2;
            //this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ModifyFont(defaultFontBold);
            //this.button12.Location = new System.Drawing.Point(190, 78);
            this.button12.Name = "button12";
            this.button12.SetSizeRequest(170, 34);
            //this.button12.TabIndex = 18;
            this.button12.Label = "button12";
            //this.button12.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            //this.button14.BackColor = System.Drawing.Color.Peru;
            //this.button14.FlatAppearance.BorderSize = 2;
            //this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ModifyFont(defaultFontBold);
            //this.button14.Location = new System.Drawing.Point(542, 78);
            this.button14.Name = "button14";
            this.button14.SetSizeRequest(170, 34);
            //this.button14.TabIndex = 16;
            this.button14.Label = "button14";
            //this.button14.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            //this.button11.BackColor = System.Drawing.Color.Peru;
            //this.button11.FlatAppearance.BorderSize = 2;
            //this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ModifyFont(defaultFontBold);
            //this.button11.Location = new System.Drawing.Point(14, 78);
            this.button11.Name = "button11";
            this.button11.SetSizeRequest(170, 34);
            //this.button11.TabIndex = 19;
            this.button11.Label = "button11";
            //this.button11.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            //this.button13.BackColor = System.Drawing.Color.Peru;
            //this.button13.FlatAppearance.BorderSize = 2;
            //this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ModifyFont(defaultFontBold);
            //this.button13.Location = new System.Drawing.Point(366, 78);
            this.button13.Name = "button13";
            this.button13.SetSizeRequest(170, 34);
            //this.button13.TabIndex = 17;
            //this.button13.Label = "button13";
            this.button13.Label = "button13";
            //this.button13.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            // //this.button15.BackColor = System.Drawing.Color.Peru;
            // //this.button15.FlatAppearance.BorderSize = 2;
            ////this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ModifyFont(defaultFontBold);
            ////this.button15.Location = new System.Drawing.Point(718, 78);
            this.button15.Name = "button15";
            this.button15.SetSizeRequest(170, 34);
            ////this.button15.TabIndex = 15;
            //this.button15.Label = "button15";
            ////this.button15.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            //this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))),
            //    ((int)(((byte)(128)))));
            // //this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Add(this.richTextBoxSub);
            // //this.panel3.Location = new System.Drawing.Point(10, 112);
            this.panel3.Name = "panel3";
            this.panel3.SetSize(330, 408);
            ////this.panel3.TabIndex = 6;
            // 
            // richTextBoxSub
            // 
            ////this.richTextBoxSub.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBoxSub.ModifyFont(FontDescription.FromString("Microsoft Sans Serif 10"));

            // //this.richTextBoxSub.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxSub.Name = "richTextBoxSub";
            this.richTextBoxSub.SetSizeRequest(322, 400);
            ////this.richTextBoxSub.TabIndex = 0;
            //this.richTextBoxSub.Text = "";
            // this.richTextBoxSub.TextChanged += new System.EventHandler(this.richTextBoxSub_TextChanged);
            // 
            // PlayerStatsPanel
            // 
            ////this.PlayerStatsPanel.BackColor = System.Drawing.Color.SteelBlue;
            ////this.PlayerStatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerStatsPanel.Add(this.progressBarLust);
            this.PlayerStatsPanel.Add(this.labelLibido);
            this.PlayerStatsPanel.Add(this.labelStrenght);
            this.PlayerStatsPanel.Add(this.progressBarHP);
            this.PlayerStatsPanel.Add(this.label6);
            this.PlayerStatsPanel.Add(this.label1);
            this.PlayerStatsPanel.Add(this.labelToughness);
            this.PlayerStatsPanel.Add(this.labelLust);
            this.PlayerStatsPanel.Add(this.label5);
            this.PlayerStatsPanel.Add(this.label2);
            this.PlayerStatsPanel.Add(this.labelSpeed);
            this.PlayerStatsPanel.Add(this.labelHP);
            this.PlayerStatsPanel.Add(this.label4);
            this.PlayerStatsPanel.Add(this.label3);
            // //this.PlayerStatsPanel.Location = new System.Drawing.Point(10, 10);
            this.PlayerStatsPanel.Name = "PlayerStatsPanel";
            this.PlayerStatsPanel.SetSize(330, 93);
            ////this.PlayerStatsPanel.TabIndex = 7;
            // 
            // AdditionalStatsPanel
            // 
            // this.AdditionalStatsPanel. = System.Drawing.Color.SteelBlue;
            // //this.AdditionalStatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalStatsPanel.Add(this.progressBarExp);
            this.AdditionalStatsPanel.Add(this.label10);
            this.AdditionalStatsPanel.Add(this.labelDay);
            this.AdditionalStatsPanel.Add(this.label11);
            this.AdditionalStatsPanel.Add(this.labelExp);
            this.AdditionalStatsPanel.Add(this.labelLevel);
            this.AdditionalStatsPanel.Add(this.label7);
            this.AdditionalStatsPanel.Add(this.label9);
            this.AdditionalStatsPanel.Add(this.labelCoins);
            this.AdditionalStatsPanel.Add(this.labelHour);
            this.AdditionalStatsPanel.Add(this.label8);
            ////this.AdditionalStatsPanel.Location = new System.Drawing.Point(10, 524);
            this.AdditionalStatsPanel.Name = "AdditionalStatsPanel";
            this.AdditionalStatsPanel.SetSize(330, 65);
            ////this.AdditionalStatsPanel.TabIndex = 8;
            // 
            // MainActionsPanel
            // 
            ////this.MainActionsPanel.BackColor = System.Drawing.Color.DarkOrange;
            ////this.MainActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainActionsPanel.Add(this.btnOptions);
            this.MainActionsPanel.Add(this.btnLoad);
            this.MainActionsPanel.Add(this.btnSave);
            this.MainActionsPanel.Add(this.btnNewGame);
            ////this.MainActionsPanel.Location = new System.Drawing.Point(10, 594);
            this.MainActionsPanel.Name = "MainActionsPanel";
            //this.MainActionsPanel.SetSizeRequest(330, 82);
            this.ActionPanelLocation.Add(MainActionsPanel);
            ////this.MainActionsPanel.TabIndex = 9;
            // 
            // TestFormX
            // 
            // MainWindow.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            // MainWindow.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //MainWindow.BackColor = System.Drawing.Color.LightSteelBlue;
            // MainWindow.ClientSize = new System.Drawing.Size(1264, 681);
            MainWindow.Resize(1264, 681);

            mainPanel.Add(this.ActionPanelLocation);
            //mainPanel.Add(this.AdditionalStatsPanel);
            //mainPanel.Add(this.PlayerStatsPanel);
            //mainPanel.Add(this.panel3);
            //mainPanel.Add(this.ActionbuttonHolder);
            //mainPanel.Add(this.MainStoryTextPanel);
            MainWindow.Add(mainPanel);
            MainWindow.Name = "TestFormX";
            MainWindow.ShowAll();
            //MainWindow.Text = "TestFormX";
        }

        public RealUI_Glade()
        {
            initComponents();
        }
    }
}