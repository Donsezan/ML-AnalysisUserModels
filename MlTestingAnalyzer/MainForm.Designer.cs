using ChartDirector;

namespace WindowsFormsMLTest
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PuzzletextBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MeTVtextBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PuzzlestextBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.QuizzestextBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SolitairetextBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StrategytextBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WordtextBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MatchingtextBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CrosswordtextBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CasinotextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CardTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrainTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArcadeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox1 = new ChartDirector.WinChartViewer();
            this.pictureBox2 = new ChartDirector.WinChartViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OptionButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.AllowDrop = true;
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(113, 79);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(323, 460);
            this.InputTextBox.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(194, 545);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(242, 25);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Send ML";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(442, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(712, 170);
            this.OutputTextBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 459);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(334, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load CSV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextBox.Location = new System.Drawing.Point(12, 48);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(312, 26);
            this.PathTextBox.TabIndex = 5;
            this.PathTextBox.Text = "Path to Csv DataBase";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuzzletextBox12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.MeTVtextBox11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.PuzzlestextBox10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.QuizzestextBox9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.SolitairetextBox8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.StrategytextBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.WordtextBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MatchingtextBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CrosswordtextBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CasinotextBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CardTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BrainTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ArcadeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ActionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(442, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Category vector";
            // 
            // PuzzletextBox12
            // 
            this.PuzzletextBox12.Enabled = false;
            this.PuzzletextBox12.Location = new System.Drawing.Point(54, 88);
            this.PuzzletextBox12.Name = "PuzzletextBox12";
            this.PuzzletextBox12.Size = new System.Drawing.Size(37, 20);
            this.PuzzletextBox12.TabIndex = 27;
            this.PuzzletextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Puzzle";
            // 
            // MeTVtextBox11
            // 
            this.MeTVtextBox11.Enabled = false;
            this.MeTVtextBox11.Location = new System.Drawing.Point(7, 88);
            this.MeTVtextBox11.Name = "MeTVtextBox11";
            this.MeTVtextBox11.Size = new System.Drawing.Size(37, 20);
            this.MeTVtextBox11.TabIndex = 25;
            this.MeTVtextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "MeTV";
            // 
            // PuzzlestextBox10
            // 
            this.PuzzlestextBox10.Enabled = false;
            this.PuzzlestextBox10.Location = new System.Drawing.Point(101, 88);
            this.PuzzlestextBox10.Name = "PuzzlestextBox10";
            this.PuzzlestextBox10.Size = new System.Drawing.Size(37, 20);
            this.PuzzlestextBox10.TabIndex = 23;
            this.PuzzlestextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Puzzles";
            // 
            // QuizzestextBox9
            // 
            this.QuizzestextBox9.Enabled = false;
            this.QuizzestextBox9.Location = new System.Drawing.Point(144, 88);
            this.QuizzestextBox9.Name = "QuizzestextBox9";
            this.QuizzestextBox9.Size = new System.Drawing.Size(37, 20);
            this.QuizzestextBox9.TabIndex = 21;
            this.QuizzestextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quizzes";
            // 
            // SolitairetextBox8
            // 
            this.SolitairetextBox8.Enabled = false;
            this.SolitairetextBox8.Location = new System.Drawing.Point(187, 88);
            this.SolitairetextBox8.Name = "SolitairetextBox8";
            this.SolitairetextBox8.Size = new System.Drawing.Size(37, 20);
            this.SolitairetextBox8.TabIndex = 19;
            this.SolitairetextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Solitaire";
            // 
            // StrategytextBox7
            // 
            this.StrategytextBox7.Enabled = false;
            this.StrategytextBox7.Location = new System.Drawing.Point(238, 88);
            this.StrategytextBox7.Name = "StrategytextBox7";
            this.StrategytextBox7.Size = new System.Drawing.Size(37, 20);
            this.StrategytextBox7.TabIndex = 17;
            this.StrategytextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Strategy";
            // 
            // WordtextBox6
            // 
            this.WordtextBox6.Enabled = false;
            this.WordtextBox6.Location = new System.Drawing.Point(285, 88);
            this.WordtextBox6.Name = "WordtextBox6";
            this.WordtextBox6.Size = new System.Drawing.Size(37, 20);
            this.WordtextBox6.TabIndex = 15;
            this.WordtextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Word";
            // 
            // MatchingtextBox5
            // 
            this.MatchingtextBox5.Enabled = false;
            this.MatchingtextBox5.Location = new System.Drawing.Point(285, 37);
            this.MatchingtextBox5.Name = "MatchingtextBox5";
            this.MatchingtextBox5.Size = new System.Drawing.Size(37, 20);
            this.MatchingtextBox5.TabIndex = 13;
            this.MatchingtextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Matching";
            // 
            // CrosswordtextBox4
            // 
            this.CrosswordtextBox4.Enabled = false;
            this.CrosswordtextBox4.Location = new System.Drawing.Point(238, 37);
            this.CrosswordtextBox4.Name = "CrosswordtextBox4";
            this.CrosswordtextBox4.Size = new System.Drawing.Size(37, 20);
            this.CrosswordtextBox4.TabIndex = 11;
            this.CrosswordtextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Crossword";
            // 
            // CasinotextBox3
            // 
            this.CasinotextBox3.Enabled = false;
            this.CasinotextBox3.Location = new System.Drawing.Point(191, 37);
            this.CasinotextBox3.Name = "CasinotextBox3";
            this.CasinotextBox3.Size = new System.Drawing.Size(37, 20);
            this.CasinotextBox3.TabIndex = 9;
            this.CasinotextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Casino";
            // 
            // CardTextBox
            // 
            this.CardTextBox.Enabled = false;
            this.CardTextBox.Location = new System.Drawing.Point(144, 37);
            this.CardTextBox.Name = "CardTextBox";
            this.CardTextBox.Size = new System.Drawing.Size(37, 20);
            this.CardTextBox.TabIndex = 7;
            this.CardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card";
            // 
            // BrainTextBox
            // 
            this.BrainTextBox.Enabled = false;
            this.BrainTextBox.Location = new System.Drawing.Point(97, 37);
            this.BrainTextBox.Name = "BrainTextBox";
            this.BrainTextBox.Size = new System.Drawing.Size(37, 20);
            this.BrainTextBox.TabIndex = 5;
            this.BrainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brain";
            // 
            // ArcadeTextBox
            // 
            this.ArcadeTextBox.Enabled = false;
            this.ArcadeTextBox.Location = new System.Drawing.Point(50, 37);
            this.ArcadeTextBox.Name = "ArcadeTextBox";
            this.ArcadeTextBox.Size = new System.Drawing.Size(37, 20);
            this.ArcadeTextBox.TabIndex = 3;
            this.ArcadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arcade";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Enabled = false;
            this.ActionTextBox.Location = new System.Drawing.Point(7, 37);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(37, 20);
            this.ActionTextBox.TabIndex = 1;
            this.ActionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Action";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(12, 549);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Auto Sending";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(410, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(330, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Get top";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Location = new System.Drawing.Point(807, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 125);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ML Category vector";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(54, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Puzzle";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(7, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "MeTV";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(101, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(99, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Puzzles";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(144, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(37, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(142, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Quizzes";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(187, 88);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(37, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(186, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Solitaire";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(238, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(37, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(235, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Strategy";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(285, 88);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(37, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(285, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Word";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(285, 37);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(37, 20);
            this.textBox9.TabIndex = 13;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(283, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Matching";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(238, 37);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(37, 20);
            this.textBox10.TabIndex = 11;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(232, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Crossword";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(191, 37);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(37, 20);
            this.textBox11.TabIndex = 9;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(191, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Casino";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(144, 37);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(37, 20);
            this.textBox12.TabIndex = 7;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(147, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Card";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(97, 37);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(37, 20);
            this.textBox13.TabIndex = 5;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(99, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Brain";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(50, 37);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(37, 20);
            this.textBox14.TabIndex = 3;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(50, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Arcade";
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(7, 37);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(37, 20);
            this.textBox15.TabIndex = 1;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Action";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(442, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 238);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(807, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 238);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // OptionButton
            // 
            this.OptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionButton.Location = new System.Drawing.Point(12, 10);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(312, 30);
            this.OptionButton.TabIndex = 31;
            this.OptionButton.Text = "Options";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(113, 545);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 25);
            this.EditButton.TabIndex = 32;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 582);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InputTextBox);
            this.Name = "MainForm";
            this.Text = "MLTest 1.3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PuzzletextBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MeTVtextBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PuzzlestextBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox QuizzestextBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SolitairetextBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StrategytextBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WordtextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MatchingtextBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CrosswordtextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CasinotextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CardTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BrainTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArcadeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label29;
        private WinChartViewer pictureBox1;
        private WinChartViewer pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Button EditButton;
    }
}

