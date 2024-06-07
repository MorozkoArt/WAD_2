namespace LABA2
{
    partial class Grafik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fon_Start = new System.Windows.Forms.Button();
            this.Color_See = new System.Windows.Forms.Label();
            this.Change_Color = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Choice_Background = new System.Windows.Forms.Button();
            this.Random_Function = new System.Windows.Forms.Button();
            this.Panel_P = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Fon_Start);
            this.groupBox1.Controls.Add(this.Color_See);
            this.groupBox1.Controls.Add(this.Change_Color);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Choice_Background);
            this.groupBox1.Controls.Add(this.Random_Function);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1273, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 1019);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(22, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(258, 51);
            this.delete.TabIndex = 8;
            this.delete.Text = "Удаление угла";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 31;
            this.listBox.Location = new System.Drawing.Point(22, 34);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(258, 252);
            this.listBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 6;
            // 
            // Fon_Start
            // 
            this.Fon_Start.Location = new System.Drawing.Point(60, 832);
            this.Fon_Start.Name = "Fon_Start";
            this.Fon_Start.Size = new System.Drawing.Size(270, 102);
            this.Fon_Start.TabIndex = 5;
            this.Fon_Start.Text = "Bернуть исходое оформление";
            this.Fon_Start.UseVisualStyleBackColor = true;
            this.Fon_Start.Click += new System.EventHandler(this.Fon_Start_Click);
            // 
            // Color_See
            // 
            this.Color_See.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color_See.Location = new System.Drawing.Point(286, 401);
            this.Color_See.Name = "Color_See";
            this.Color_See.Size = new System.Drawing.Size(64, 64);
            this.Color_See.TabIndex = 4;
            this.Color_See.Text = "        \r\n\r\n";
            // 
            // Change_Color
            // 
            this.Change_Color.Location = new System.Drawing.Point(22, 387);
            this.Change_Color.Name = "Change_Color";
            this.Change_Color.Size = new System.Drawing.Size(258, 87);
            this.Change_Color.TabIndex = 3;
            this.Change_Color.Text = "Изменение цвета графика";
            this.Change_Color.UseVisualStyleBackColor = true;
            this.Change_Color.Click += new System.EventHandler(this.Change_Color_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(22, 736);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(344, 77);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Choice_Background
            // 
            this.Choice_Background.Location = new System.Drawing.Point(22, 618);
            this.Choice_Background.Name = "Choice_Background";
            this.Choice_Background.Size = new System.Drawing.Size(344, 74);
            this.Choice_Background.TabIndex = 1;
            this.Choice_Background.Text = "Выбор фона";
            this.Choice_Background.UseVisualStyleBackColor = true;
            this.Choice_Background.Click += new System.EventHandler(this.Choice_Background_Click);
            // 
            // Random_Function
            // 
            this.Random_Function.Location = new System.Drawing.Point(22, 502);
            this.Random_Function.Name = "Random_Function";
            this.Random_Function.Size = new System.Drawing.Size(344, 79);
            this.Random_Function.TabIndex = 0;
            this.Random_Function.Text = "Случайная функция";
            this.Random_Function.UseVisualStyleBackColor = true;
            this.Random_Function.Click += new System.EventHandler(this.Random_Function_Click);
            // 
            // Panel_P
            // 
            this.Panel_P.BackColor = System.Drawing.Color.White;
            this.Panel_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_P.Location = new System.Drawing.Point(0, 0);
            this.Panel_P.Name = "Panel_P";
            this.Panel_P.Size = new System.Drawing.Size(1273, 1019);
            this.Panel_P.TabIndex = 1;
            this.Panel_P.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_P_Paint);
            this.Panel_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_P_MouseDown);
            this.Panel_P.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_P_MouseMove);
            this.Panel_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_P_MouseUp);
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 1019);
            this.Controls.Add(this.Panel_P);
            this.Controls.Add(this.groupBox1);
            this.Name = "Grafik";
            this.Text = "Desmos";
            this.SizeChanged += new System.EventHandler(this.Grafik_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Change_Color;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Choice_Background;
        private System.Windows.Forms.Button Random_Function;
        private System.Windows.Forms.Label Color_See;
        private System.Windows.Forms.Button Fon_Start;
        public System.Windows.Forms.Panel Panel_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

