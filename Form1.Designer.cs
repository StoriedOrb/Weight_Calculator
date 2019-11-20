namespace WeightCalculator
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.ResultButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.More17 = new System.Windows.Forms.RadioButton();
            this.less15 = new System.Windows.Forms.RadioButton();
            this.ot15do17 = new System.Windows.Forms.RadioButton();
            this.Age = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox3.Controls.Add(this.Male);
            this.groupBox3.Controls.Add(this.Female);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(21, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кто вы?";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.Color.Black;
            this.Male.Location = new System.Drawing.Point(18, 29);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(70, 17);
            this.Male.TabIndex = 4;
            this.Male.TabStop = true;
            this.Male.Text = "Мужчина";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.Color.Black;
            this.Female.Location = new System.Drawing.Point(17, 62);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 17);
            this.Female.TabIndex = 3;
            this.Female.TabStop = true;
            this.Female.Text = "Женщина";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.ForeColor = System.Drawing.Color.Black;
            this.ResultButton.Location = new System.Drawing.Point(263, 350);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(214, 48);
            this.ResultButton.TabIndex = 31;
            this.ResultButton.Text = "Выполнить исследование";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Orange;
            this.groupBox4.Controls.Add(this.More17);
            this.groupBox4.Controls.Add(this.less15);
            this.groupBox4.Controls.Add(this.ot15do17);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(21, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 144);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Запястье";
            // 
            // More17
            // 
            this.More17.AutoSize = true;
            this.More17.ForeColor = System.Drawing.Color.Black;
            this.More17.Location = new System.Drawing.Point(18, 102);
            this.More17.Name = "More17";
            this.More17.Size = new System.Drawing.Size(96, 17);
            this.More17.TabIndex = 2;
            this.More17.TabStop = true;
            this.More17.Text = "Больше 17 см";
            this.More17.UseVisualStyleBackColor = true;
            // 
            // less15
            // 
            this.less15.AutoSize = true;
            this.less15.ForeColor = System.Drawing.Color.Black;
            this.less15.Location = new System.Drawing.Point(19, 35);
            this.less15.Name = "less15";
            this.less15.Size = new System.Drawing.Size(98, 17);
            this.less15.TabIndex = 1;
            this.less15.TabStop = true;
            this.less15.Text = "Меньше 15 см";
            this.less15.UseVisualStyleBackColor = true;
            // 
            // ot15do17
            // 
            this.ot15do17.AutoSize = true;
            this.ot15do17.ForeColor = System.Drawing.Color.Black;
            this.ot15do17.Location = new System.Drawing.Point(18, 68);
            this.ot15do17.Name = "ot15do17";
            this.ot15do17.Size = new System.Drawing.Size(103, 17);
            this.ot15do17.TabIndex = 0;
            this.ot15do17.TabStop = true;
            this.ot15do17.Text = "От 15 до 17 см ";
            this.ot15do17.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            this.Age.ForeColor = System.Drawing.Color.Black;
            this.Age.Location = new System.Drawing.Point(109, 110);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(135, 20);
            this.Age.TabIndex = 28;
            // 
            // Height
            // 
            this.Height.ForeColor = System.Drawing.Color.Black;
            this.Height.Location = new System.Drawing.Point(109, 73);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(135, 20);
            this.Height.TabIndex = 27;
            // 
            // Weight
            // 
            this.Weight.ForeColor = System.Drawing.Color.Black;
            this.Weight.Location = new System.Drawing.Point(109, 32);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(135, 20);
            this.Weight.TabIndex = 26;
            // 
            // ResultText
            // 
            this.ResultText.ForeColor = System.Drawing.Color.Black;
            this.ResultText.Location = new System.Drawing.Point(263, 44);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultText.Size = new System.Drawing.Size(214, 300);
            this.ResultText.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(261, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Результаты расчетов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Возраст (лет)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(18, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Рост (см)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Вес (кг)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(498, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Калькулятор веса";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton More17;
        private System.Windows.Forms.RadioButton less15;
        private System.Windows.Forms.RadioButton ot15do17;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

