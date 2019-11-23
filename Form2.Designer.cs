namespace WeightCalculator
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчёт индекса массы тела";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Location = new System.Drawing.Point(12, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Расчёт идеального веса по формуле Креффа (Формула ведёт расчёт с учетом комплекци" +
    "и)";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.Location = new System.Drawing.Point(13, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Расчёт идеального веса по формуле Купера (Формула ведёт расчёт с учётом пола)";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.Location = new System.Drawing.Point(215, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "Расчёи нормы веса исходя из фиксированного весо-ростового коэффициента";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button5.Location = new System.Drawing.Point(215, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "Расчёт идеального веса по формуле Лоренца(идёт учёт пола. Подходит людям старше 1" +
    "8 лет и ростом от 140 до 220)";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button6.Location = new System.Drawing.Point(216, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "Расчёт калорийности суточного рациона и расход каллорий  по формуле Тома Венуто(И" +
    "дёт учёт пола и физической активности)";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(425, 218);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Выбор формулы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}