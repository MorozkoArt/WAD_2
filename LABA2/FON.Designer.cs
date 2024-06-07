namespace LABA2
{
    partial class FON
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
            this.net_chec = new System.Windows.Forms.CheckBox();
            this.chec_gradient = new System.Windows.Forms.CheckBox();
            this.period_net_exist_chec = new System.Windows.Forms.CheckBox();
            this.trackBar_Net = new System.Windows.Forms.TrackBar();
            this.period_net_trackBar = new System.Windows.Forms.TrackBar();
            this.period_net_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bgradient1 = new System.Windows.Forms.Button();
            this.bgradient2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.label_fon = new System.Windows.Forms.Label();
            this.label_net = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_gradient1 = new System.Windows.Forms.Label();
            this.label_gradient2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_axis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Net)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_net_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_net_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // net_chec
            // 
            this.net_chec.AutoSize = true;
            this.net_chec.Location = new System.Drawing.Point(50, 138);
            this.net_chec.Name = "net_chec";
            this.net_chec.Size = new System.Drawing.Size(259, 36);
            this.net_chec.TabIndex = 0;
            this.net_chec.Text = "Включить сетку";
            this.net_chec.UseVisualStyleBackColor = true;
            this.net_chec.CheckedChanged += new System.EventHandler(this.net_chec_CheckedChanged);
            // 
            // chec_gradient
            // 
            this.chec_gradient.AutoSize = true;
            this.chec_gradient.Location = new System.Drawing.Point(50, 642);
            this.chec_gradient.Name = "chec_gradient";
            this.chec_gradient.Size = new System.Drawing.Size(308, 36);
            this.chec_gradient.TabIndex = 1;
            this.chec_gradient.Text = "Добавить градиент";
            this.chec_gradient.UseVisualStyleBackColor = true;
            this.chec_gradient.CheckedChanged += new System.EventHandler(this.chec_gradient_CheckedChanged);
            // 
            // period_net_exist_chec
            // 
            this.period_net_exist_chec.AutoSize = true;
            this.period_net_exist_chec.Location = new System.Drawing.Point(50, 255);
            this.period_net_exist_chec.Name = "period_net_exist_chec";
            this.period_net_exist_chec.Size = new System.Drawing.Size(501, 36);
            this.period_net_exist_chec.TabIndex = 2;
            this.period_net_exist_chec.Text = "Включить вспомогательную сетку";
            this.period_net_exist_chec.UseVisualStyleBackColor = true;
            this.period_net_exist_chec.CheckedChanged += new System.EventHandler(this.period_net_exist_chec_CheckedChanged);
            // 
            // trackBar_Net
            // 
            this.trackBar_Net.Location = new System.Drawing.Point(964, 142);
            this.trackBar_Net.Minimum = 1;
            this.trackBar_Net.Name = "trackBar_Net";
            this.trackBar_Net.Size = new System.Drawing.Size(338, 114);
            this.trackBar_Net.TabIndex = 3;
            this.trackBar_Net.Value = 1;
            this.trackBar_Net.Scroll += new System.EventHandler(this.trackBar_Net_Scroll);
            // 
            // period_net_trackBar
            // 
            this.period_net_trackBar.Location = new System.Drawing.Point(964, 257);
            this.period_net_trackBar.Minimum = 1;
            this.period_net_trackBar.Name = "period_net_trackBar";
            this.period_net_trackBar.Size = new System.Drawing.Size(338, 114);
            this.period_net_trackBar.TabIndex = 4;
            this.period_net_trackBar.Value = 1;
            this.period_net_trackBar.Scroll += new System.EventHandler(this.period_net_trackBar_Scroll);
            // 
            // period_net_numericUpDown
            // 
            this.period_net_numericUpDown.Location = new System.Drawing.Point(587, 373);
            this.period_net_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.period_net_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.period_net_numericUpDown.Name = "period_net_numericUpDown";
            this.period_net_numericUpDown.Size = new System.Drawing.Size(120, 38);
            this.period_net_numericUpDown.TabIndex = 5;
            this.period_net_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.period_net_numericUpDown.ValueChanged += new System.EventHandler(this.period_net_numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Период вспомогательных линий";
            // 
            // bgradient1
            // 
            this.bgradient1.Location = new System.Drawing.Point(457, 642);
            this.bgradient1.Name = "bgradient1";
            this.bgradient1.Size = new System.Drawing.Size(259, 72);
            this.bgradient1.TabIndex = 7;
            this.bgradient1.Text = "Первый цвет градиента";
            this.bgradient1.UseVisualStyleBackColor = true;
            this.bgradient1.Click += new System.EventHandler(this.bgradient1_Click);
            // 
            // bgradient2
            // 
            this.bgradient2.Location = new System.Drawing.Point(795, 642);
            this.bgradient2.Name = "bgradient2";
            this.bgradient2.Size = new System.Drawing.Size(259, 72);
            this.bgradient2.TabIndex = 8;
            this.bgradient2.Text = "Второй цвет градиента";
            this.bgradient2.UseVisualStyleBackColor = true;
            this.bgradient2.Click += new System.EventHandler(this.bgradient2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 64);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберете толщину\r\n          сетки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 64);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберете толщину \r\nвспомогательной сетки";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(314, 96);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить цвет фона";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(468, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 96);
            this.button4.TabIndex = 12;
            this.button4.Text = "Изменить цвет сетки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(448, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "Настройка фона";
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(815, 776);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(251, 59);
            this.Yes.TabIndex = 14;
            this.Yes.Text = "Принять";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(1101, 776);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(251, 59);
            this.No.TabIndex = 15;
            this.No.Text = "Отменить";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // label_fon
            // 
            this.label_fon.BackColor = System.Drawing.Color.White;
            this.label_fon.Location = new System.Drawing.Point(350, 495);
            this.label_fon.Name = "label_fon";
            this.label_fon.Size = new System.Drawing.Size(58, 49);
            this.label_fon.TabIndex = 16;
            // 
            // label_net
            // 
            this.label_net.BackColor = System.Drawing.Color.Gray;
            this.label_net.Location = new System.Drawing.Point(789, 495);
            this.label_net.Name = "label_net";
            this.label_net.Size = new System.Drawing.Size(58, 49);
            this.label_net.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(722, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 53);
            this.label5.TabIndex = 18;
            // 
            // label_gradient1
            // 
            this.label_gradient1.BackColor = System.Drawing.Color.White;
            this.label_gradient1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_gradient1.Location = new System.Drawing.Point(722, 655);
            this.label_gradient1.Name = "label_gradient1";
            this.label_gradient1.Size = new System.Drawing.Size(56, 53);
            this.label_gradient1.TabIndex = 18;
            // 
            // label_gradient2
            // 
            this.label_gradient2.BackColor = System.Drawing.Color.White;
            this.label_gradient2.Location = new System.Drawing.Point(1060, 655);
            this.label_gradient2.Name = "label_gradient2";
            this.label_gradient2.Size = new System.Drawing.Size(56, 53);
            this.label_gradient2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 96);
            this.button1.TabIndex = 20;
            this.button1.Text = "Изменить цвет осей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_axis
            // 
            this.label_axis.BackColor = System.Drawing.Color.Black;
            this.label_axis.Location = new System.Drawing.Point(1202, 495);
            this.label_axis.Name = "label_axis";
            this.label_axis.Size = new System.Drawing.Size(58, 49);
            this.label_axis.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1321, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1321, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 23;
            // 
            // FON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 861);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_axis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_gradient2);
            this.Controls.Add(this.label_gradient1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_net);
            this.Controls.Add(this.label_fon);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bgradient2);
            this.Controls.Add(this.bgradient1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.period_net_numericUpDown);
            this.Controls.Add(this.period_net_trackBar);
            this.Controls.Add(this.trackBar_Net);
            this.Controls.Add(this.period_net_exist_chec);
            this.Controls.Add(this.chec_gradient);
            this.Controls.Add(this.net_chec);
            this.Name = "FON";
            this.Text = "FON";
            this.Load += new System.EventHandler(this.FON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Net)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_net_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_net_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox net_chec;
        private System.Windows.Forms.CheckBox chec_gradient;
        private System.Windows.Forms.CheckBox period_net_exist_chec;
        private System.Windows.Forms.TrackBar trackBar_Net;
        private System.Windows.Forms.TrackBar period_net_trackBar;
        private System.Windows.Forms.NumericUpDown period_net_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bgradient1;
        private System.Windows.Forms.Button bgradient2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label label_fon;
        private System.Windows.Forms.Label label_net;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_gradient1;
        private System.Windows.Forms.Label label_gradient2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_axis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}