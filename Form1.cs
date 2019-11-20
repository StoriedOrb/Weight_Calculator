using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightCalculator
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
            this.Show();

            double IMT, weight, height, age, koef, idealweight;

            height = Convert.ToDouble(Height.Text);

            if (height > 230)                                       //Ограничение роста
            {
                MessageBox.Show("Ваш рост не может быть таким.");

                Height.Clear();
            }

            weight = Convert.ToDouble(Weight.Text);

            if (weight > 200)                                      //Ограничение веса
            {
                MessageBox.Show("Ваш вес не может быть таким.");

                Weight.Clear();
            }

            age = Convert.ToDouble(Age.Text);

            if (age > 100)                                         //Ограничение возраста
            {
                MessageBox.Show("Ваш возраст не может быть таким.");

                Age.Clear();
            }

            IMT = weight / (height * height);                        //Индекс массы тела по Кетле

            if (IMT < 18.5)
            {
                ResultText.Text += "По формуле Кетле у вас Дефицит массы тела" + Environment.NewLine;
            }

            if (IMT > 18.5 && IMT < 24.9)
            {
                ResultText.Text += "По формуле Кетле у вас Нормальная масса тела" + Environment.NewLine;
            }

            if (IMT > 25 && IMT < 29.9)
            {
                ResultText.Text += "По формуле Кетле у вас Избыточная масса тела" + Environment.NewLine;
            }

            if (IMT > 30 && IMT < 34.9)
            {
                ResultText.Text += "По формуле Кетле у вас Ожирение 1-ой степени" + Environment.NewLine;
            }

            if (IMT > 35 && IMT < 39.9)
            {
                ResultText.Text += "По формуле Кетле у вас Ожирение 1-ой степени" + Environment.NewLine;
            }

            if (IMT > 40)
            {
                ResultText.Text += "По формуле Кетле у вас Ожирение 1-ой степени" + Environment.NewLine;
            }
            

            if (less15.Checked == true)                            //Формула Крефа для расчёта идеального веса
            {
                koef = 0.9;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }
            }

            if (ot15do17.Checked == true)
            {
                koef = 1.0;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }
            }

            if (More17.Checked == true)
            {
                koef = 1.1;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine;
                }
            }

            if (Male.Checked == true)                                     //Расчет идеального веса по формуле Купера для мужчин
            {
                idealweight = (height * 4.0 / 2.54 - 128) * 0.453;

                ResultText.Text += "Ваш идеальный вес по формуле Купера = " + idealweight + "кг" + Environment.NewLine;
            }

            if (Female.Checked == true)                                     //Расчет идеального веса по формуле Купера для женщин
            {
                idealweight = (height * 3.5 / 2.54 - 108) * 0.453;

                ResultText.Text += "Ваш идеальный вес по формуле Купера = " + idealweight + "кг" + Environment.NewLine;
            }












        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
