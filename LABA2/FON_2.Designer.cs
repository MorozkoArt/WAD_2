namespace LABA2
{
    partial class FON_2
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
            this.OK = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(411, 840);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(237, 63);
            this.OK.TabIndex = 4;
            this.OK.Text = "Принять";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // NO
            // 
            this.NO.Location = new System.Drawing.Point(737, 840);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(237, 63);
            this.NO.TabIndex = 5;
            this.NO.Text = "Отмена";
            this.NO.UseVisualStyleBackColor = true;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // button4
            // 
            this.button4.Image = global::LABA2.Properties.Resources.button4_4_4;
            this.button4.Location = new System.Drawing.Point(849, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(512, 310);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::LABA2.Properties.Resources.button3_3_3;
            this.button3.Location = new System.Drawing.Point(56, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(497, 310);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::LABA2.Properties.Resources.button2_2__2jpg;
            this.button2.Location = new System.Drawing.Point(849, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(512, 299);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::LABA2.Properties.Resources.button1_1_1;
            this.button1.Location = new System.Drawing.Point(56, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(497, 299);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1119, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите один из 4-ёх предложенных стилей";
            // 
            // FON_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 972);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(750, 70);
            this.Name = "FON_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FON_2";
            this.Load += new System.EventHandler(this.FON_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Label label1;
    }
}