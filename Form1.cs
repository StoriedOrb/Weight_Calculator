using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_your_lunch
{
    public partial class Create_your_lunch : Form
    {

        int FP = 0, HP = 0, MP = 0, BBQ = 0, CP = 0, BM = 0, P = 0, R = 0, BT = 0, MF = 0, CR = 0, TL = 0, FR = 0, SY = 0, SL = 0, DCurier = 0, DCycle = 0, DCar = 0, DHelicopter = 0;

        public Create_your_lunch()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clean_Click(object sender, EventArgs e)       //Кнопка очистить
        {
            CheckList.Clear();
            FamilyPizza.Checked = false;
            HavaiPizza.Checked = false;
            MeatPizza.Checked = false;
            PizzaBBQ.Checked = false;
            CheesePizza.Checked = false;
            BigMac.Checked = false;
            Potato.Checked = false;
            Royal.Checked = false;
            BigTasty.Checked = false;
            MacFlury.Checked = false;
            CaliforniaRoll.Checked = false;
            TempuraLosos.Checked = false;
            FiladelfiaRoll.Checked = false;
            SushiYgor.Checked = false;
            SushiLosos.Checked = false;
            Curier.Checked = false;
            Curier_cycle.Checked = false;
            Curier_car.Checked = false;
            Curier_helicopter.Checked = false;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int itog;

            if (FamilyPizza.Checked == true)
            {
                CheckList.Text += "Семейная пицца – 300 рублей" + Environment.NewLine;

                FP = 300;
            }

            if (HavaiPizza.Checked == true)
            {
                CheckList.Text += "Гавайская пицца – 330 рублей" + Environment.NewLine;

                HP = 330;
            }

            if (MeatPizza.Checked == true)
            {
                CheckList.Text += "Мясная пицца – 350 руб" + Environment.NewLine;

                MP = 350;
            }

            if (PizzaBBQ.Checked == true)
            {
                CheckList.Text += "Пицца BBQ – 400 рублей" + Environment.NewLine;

                BBQ = 400;
            }

            if (CheesePizza.Checked == true)
            {
                CheckList.Text += "Cырная пицца  – 280 рублей" + Environment.NewLine;

                CP = 280;
            }

            if (BigMac.Checked == true)
            {
                CheckList.Text += "Биг мак – 140 рублей" + Environment.NewLine;

                BM = 140;
            }

            if (Potato.Checked == true)
            {
                CheckList.Text += "Картофель фри – 100 рублей" + Environment.NewLine;

                P = 100;
            }

            if (Royal.Checked == true)
            {
                CheckList.Text += "Роял бургер – 200 рублей" + Environment.NewLine;

                R = 200;
            }

            if (BigTasty.Checked == true)
            {
                CheckList.Text += "Биг тэйсти – 250 рублей" + Environment.NewLine;

                BT = 250;
            }

            if (MacFlury.Checked == true)
            {
                CheckList.Text += "Мак флури – 120 рублей" + Environment.NewLine;

                MF = 120;
            }

            if (CaliforniaRoll.Checked == true)
            {
                CheckList.Text += "Калифорния ролл – 250 рублей" + Environment.NewLine;

                CR = 250;
            }

            if (TempuraLosos.Checked == true)
            {
                CheckList.Text += "Темпура лосось – 300 рублей" + Environment.NewLine;

                TL = 300;
            }

            if (FiladelfiaRoll.Checked == true)
            {
                CheckList.Text += "Филадельфия ролл – 300 рублей" + Environment.NewLine;

                FR = 300;
            }

            if (SushiYgor.Checked == true)
            {
                CheckList.Text += "Суши с угрём – 80 рублей" + Environment.NewLine;

                SY = 80;
            }

            if (SushiLosos.Checked == true)
            {
                CheckList.Text += "Суши с лососем – 80 рублей" + Environment.NewLine;

                SL = 80;
            }
            
            if (Curier.Checked == true)
            {
                CheckList.Text += "Доставка – Бесплатно" + Environment.NewLine;

                DCurier = 0;
            }
            
            if (Curier_cycle.Checked == true)
            {
                CheckList.Text += "Доставка – 100 рублей" + Environment.NewLine;

                DCycle = 100;
            }
            
            if (Curier_car.Checked == true)
            {
                CheckList.Text += "Доставка – 250 рублей" + Environment.NewLine;

                DCar = 250;
            }
            
            if (Curier_helicopter.Checked == true)
            {
                CheckList.Text += "Доставка – 5000 рублей" + Environment.NewLine;

                DHelicopter = 5000;  
            }
            
            itog = FP + HP + MP + BBQ + CP + BM + P + R + BT + MF + CR + TL + FR + SY + SL + DCurier + DCycle + DCar + DHelicopter;

            CheckList.Text += "Итог:" + itog + "рублей";
        } 
    }
}
