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


            double IMT, weight, height, age, koef, idealweight, OBSR, RK, Raznica;

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
                ResultText.Text += "По формуле Кетле у вас Ожирение 2-ой степени" + Environment.NewLine;
            }

            if (IMT > 40)
            {
                ResultText.Text += "По формуле Кетле у вас Ожирение 3-ой степени" + Environment.NewLine;
            }
            

            if (less15.Checked == true)                            //Формула Крефа для расчёта идеального веса для запястья > 15
            {
                koef = 0.9;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }

            if (ot15do17.Checked == true)                           //Формула Крефа для расчёта идеального веса для запястья от 15 до 17
            {
                koef = 1.0;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }

            if (More17.Checked == true)                               //Формула Крефа для расчёта идеального веса для запястья < 15
            {
                koef = 1.1;

                if (height < 155)
                {
                    idealweight = height - 95 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 155 && height < 175)
                {
                    idealweight = height - 100 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (height > 175)
                {
                    idealweight = height - 110 + (age / 10) * 0.9 * koef;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес по формуле Крефа = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }

            if (Male.Checked == true)                                     //Расчет идеального веса по формуле Купера для мужчин
            {
                idealweight = (height * 4.0 / 2.54 - 128) * 0.453;

                if (weight > idealweight)
                {
                    Raznica = weight - idealweight;
                }
                else
                {
                    Raznica = idealweight - weight;
                }

                ResultText.Text += "Ваш идеальный вес по формуле Купера = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
            }

            if (Female.Checked == true)                                     //Расчет идеального веса по формуле Купера для женщин
            {
                idealweight = (height * 3.5 / 2.54 - 108) * 0.453;

                if (weight > idealweight)
                {
                    Raznica = weight - idealweight;
                }
                else
                {
                    Raznica = idealweight - weight;
                }

                ResultText.Text += "Ваш идеальный вес по формуле Купера = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
            }

            if (age > 15 && age < 18)                                      //Расчёт идеального веса исходя из фиксированного весо-ростового коэффициента для возраста от 15 до 18
            {
                if (less15.Checked == true)
                {
                    koef = 315;
                    
                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (ot15do17.Checked == true)
                {
                    koef = 325;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (More17.Checked == true)
                {
                    koef = 355;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }

            if (age > 19 && age < 25)                                     //Расчёт идеального веса исходя из фиксированного весо-ростового коэффициента для возраста от 19 до 25
            {
                if (less15.Checked == true)
                {
                    koef = 325;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (ot15do17.Checked == true)
                {
                    koef = 345;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (More17.Checked == true)
                {
                    koef = 370;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }

            if (age > 26 && age < 40)                                      //Расчёт идеального веса исходя из фиксированного весо-ростового коэффициента для возраста от 26 до 40
            {
                if (less15.Checked == true)
                {
                    koef = 335;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (ot15do17.Checked == true)
                {
                    koef = 360;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }

                if (More17.Checked == true)
                {
                    koef = 380;

                    idealweight = (height * koef) / 1000;

                    if (weight > idealweight)
                    {
                        Raznica = weight - idealweight;
                    }
                    else
                    {
                        Raznica = idealweight - weight;
                    }

                    ResultText.Text += "Ваш идеальный вес исходя из фиксированного весо-ростового коэффициента = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
                }
            }
            
            if (Male.Checked == true)                                  //Формула Лоренца для расчёта идеального веса у мужчин
            {
                idealweight = height - 100 - ((height - 150) / 4);

                if (weight > idealweight)
                {
                    Raznica = weight - idealweight;
                }
                else
                {
                    Raznica = idealweight - weight;
                }

                ResultText.Text += "Ваш идеальный вес по формуле Лоренца = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
            }

            if (Female.Checked == true)                                //Формула Лоренца для расчёта идеального веса у женщин
            {
                idealweight = height - 100 - ((height - 150) / 2);

                if (weight > idealweight)
                {
                    Raznica = weight - idealweight;
                }
                else
                {
                    Raznica = idealweight - weight;
                }

                ResultText.Text += "Ваш идеальный вес по формуле Лоренца = " + idealweight + "кг" + Environment.NewLine + "Разница с вашим весом " + Raznica + "кг" + Environment.NewLine + Environment.NewLine;
            }

            if (Male.Checked == true)                                  //Формула Тома Венуто для расчёта калорийности суточного рациона у мужчин
            {
                OBSR = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);


                if (Malaya.Checked == true)                           //Расход калорий у мужчин в зависимости от физической активности
                {
                    koef = 1.2;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Ymerennaya.Checked == true)
                {
                    koef = 1.38;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Visokaya.Checked == true)
                {
                    koef = 1.56;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (OchenVisokaya.Checked == true)
                {
                    koef = 1.73;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Predelnaya.Checked == true)
                {
                    koef = 1.95;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }
            }

            if (Female.Checked == true)                                  //Формула Тома Венуто для расчёта калорийности суточного рациона у женщин
            {
                OBSR = 65 + (9.6 * weight) + (1.8 * height) - (4.7 * age);

                if (Malaya.Checked == true)                              ////Расход калорий у женщин в зависимости от физической активности
                {
                    koef = 1.2;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Ymerennaya.Checked == true)
                {
                    koef = 1.38;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Visokaya.Checked == true)
                {
                    koef = 1.56;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (OchenVisokaya.Checked == true)
                {
                    koef = 1.73;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }

                if (Predelnaya.Checked == true)
                {
                    koef = 1.95;

                    RK = OBSR * koef;

                    ResultText.Text += "Калорийность вашего основного обмена суточного рациона составляет = " + OBSR + "калл" + Environment.NewLine;
                    ResultText.Text += "Ваш ежедневный расход калорий = " + RK + "калл" + Environment.NewLine;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
