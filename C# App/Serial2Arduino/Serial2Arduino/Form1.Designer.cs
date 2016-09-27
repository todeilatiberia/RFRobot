namespace Serial2Arduino
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upBaudRate = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRecv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.indicator = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.distanta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lumini = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baterie = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.led1 = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRedresh = new System.Windows.Forms.Button();
            this.agA1 = new AquaControls.AquaGauge();
            ((System.ComponentModel.ISupportInitialize)(this.upBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(46, 8);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(72, 21);
            this.cmbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate:";
            // 
            // upBaudRate
            // 
            this.upBaudRate.Location = new System.Drawing.Point(234, 8);
            this.upBaudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upBaudRate.Name = "upBaudRate";
            this.upBaudRate.Size = new System.Drawing.Size(76, 20);
            this.upBaudRate.TabIndex = 4;
            this.upBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(333, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 21);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Conectare";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtRecv
            // 
            this.txtRecv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecv.Location = new System.Drawing.Point(10, 232);
            this.txtRecv.Multiline = true;
            this.txtRecv.Name = "txtRecv";
            this.txtRecv.ReadOnly = true;
            this.txtRecv.Size = new System.Drawing.Size(481, 168);
            this.txtRecv.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 7);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Gray;
            this.indicator.LargeChange = 15;
            this.indicator.Location = new System.Drawing.Point(444, 50);
            this.indicator.Maximum = 255;
            this.indicator.Minimum = 100;
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(149, 45);
            this.indicator.SmallChange = 5;
            this.indicator.TabIndex = 20;
            this.indicator.Value = 100;
            this.indicator.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "Speed";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // distanta
            // 
            this.distanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanta.Location = new System.Drawing.Point(676, 183);
            this.distanta.Name = "distanta";
            this.distanta.ReadOnly = true;
            this.distanta.Size = new System.Drawing.Size(100, 29);
            this.distanta.TabIndex = 22;
            this.distanta.TextChanged += new System.EventHandler(this.distanta_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(526, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Distance";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lumini
            // 
            this.lumini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumini.Location = new System.Drawing.Point(530, 136);
            this.lumini.Name = "lumini";
            this.lumini.Size = new System.Drawing.Size(131, 34);
            this.lumini.TabIndex = 25;
            this.lumini.Text = "Lights";
            this.lumini.UseVisualStyleBackColor = true;
            this.lumini.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(46, 29);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // baterie
            // 
            this.baterie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.baterie.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.baterie.Location = new System.Drawing.Point(13, 13);
            this.baterie.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.baterie.Maximum = 990;
            this.baterie.Minimum = 650;
            this.baterie.Name = "baterie";
            this.baterie.Size = new System.Drawing.Size(156, 24);
            this.baterie.Step = 100;
            this.baterie.TabIndex = 28;
            this.baterie.Value = 650;
            this.baterie.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.baterie);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(662, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 75);
            this.panel1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(65, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "V";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(656, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 31);
            this.label12.TabIndex = 30;
            this.label12.Text = "Battery Voltage";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(676, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(676, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(676, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(676, 360);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Temperature";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Pressure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Atmosphere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Altitude";
            // 
            // led1
            // 
            this.led1.Image = global::Serial2Arduino.Properties.Resources.led_gray;
            this.led1.Location = new System.Drawing.Point(608, 3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(42, 42);
            this.led1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.led1.TabIndex = 17;
            this.led1.TabStop = false;
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Info;
            this.btnRight.Enabled = false;
            this.btnRight.Image = global::Serial2Arduino.Properties.Resources.forward_icon1;
            this.btnRight.Location = new System.Drawing.Point(150, 100);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 44);
            this.btnRight.TabIndex = 11;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Image = global::Serial2Arduino.Properties.Resources.down_icon;
            this.btnDown.Location = new System.Drawing.Point(83, 159);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(58, 44);
            this.btnDown.TabIndex = 10;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.AllowDrop = true;
            this.btnUp.Enabled = false;
            this.btnUp.Image = global::Serial2Arduino.Properties.Resources.up_icon;
            this.btnUp.Location = new System.Drawing.Point(83, 50);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(58, 44);
            this.btnUp.TabIndex = 9;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Image = global::Serial2Arduino.Properties.Resources.back_icon;
            this.btnLeft.Location = new System.Drawing.Point(14, 100);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 44);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRedresh
            // 
            this.btnRedresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRedresh.Image = global::Serial2Arduino.Properties.Resources.refresh_icon;
            this.btnRedresh.Location = new System.Drawing.Point(131, 8);
            this.btnRedresh.Name = "btnRedresh";
            this.btnRedresh.Size = new System.Drawing.Size(24, 20);
            this.btnRedresh.TabIndex = 6;
            this.btnRedresh.UseVisualStyleBackColor = true;
            this.btnRedresh.Click += new System.EventHandler(this.btnRedresh_Click);
            // 
            // agA1
            // 
            this.agA1.BackColor = System.Drawing.Color.Transparent;
            this.agA1.DialColor = System.Drawing.Color.Lavender;
            this.agA1.DialText = "km/h";
            this.agA1.Glossiness = 11.36364F;
            this.agA1.Location = new System.Drawing.Point(238, 38);
            this.agA1.MaxValue = 3.2F;
            this.agA1.MinValue = 0F;
            this.agA1.Name = "agA1";
            this.agA1.RecommendedValue = 0F;
            this.agA1.Size = new System.Drawing.Size(188, 188);
            this.agA1.TabIndex = 13;
            this.agA1.ThresholdPercent = 0F;
            this.agA1.Value = 0F;
            this.agA1.Load += new System.EventHandler(this.agA1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(872, 412);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lumini);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.distanta);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.agA1);
            this.Controls.Add(this.txtRecv);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRedresh);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.upBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPort);
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Comm Arduino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formtest);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dezactivare);
            ((System.ComponentModel.ISupportInitialize)(this.upBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upBaudRate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRedresh;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtRecv;
        private AquaControls.AquaGauge agA1;
        private System.Windows.Forms.PictureBox led1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar indicator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox distanta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lumini;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar baterie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

