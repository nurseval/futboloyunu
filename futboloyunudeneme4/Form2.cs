using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futboloyunudeneme4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuani = 0;
        int fbpuani = 0;
        int bjkpuani = 0;
        int trbpuani = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5); //burada form sayfasında sıfır yazan yerlere programdan 0 ve 5 arasında sayı
            int b = rastgele.Next(0, 5); //atamış oluyoruz. tam sayı değerlerinin label de yazılması için de string 
            int c = rastgele.Next(0, 5); //işlemini yapıyoruz.yapmadığımız takdirde labellar sıfır kalır. 
            int d = rastgele.Next(0, 5);

            label3.Text = a.ToString();
            label4.Text = b.ToString();
            label8.Text = c.ToString();
            label9.Text = d.ToString();

            if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label4.Text))
            {
                gspuani = gspuani + 3;
                gspuan.Text = gspuani.ToString();

            }
            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label3.Text))
            {
                fbpuani = fbpuani + 3;
                fbpuan.Text = fbpuani.ToString();

            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label3.Text))
            {
                gspuani = gspuani++;
                fbpuani = fbpuani++;
                fbpuan.Text = fbpuani.ToString();
                gspuan.Text = gspuani.ToString();
            }


            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label9.Text))
            {
                bjkpuani = bjkpuani + 3;
                bjkpuan.Text = bjkpuani.ToString();

            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label8.Text))
            {
                trbpuani = trbpuani + 3;
                trbpuan.Text = trbpuani.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label9.Text))
            {
                bjkpuani = bjkpuani++;
                bjkpuan.Text = bjkpuani.ToString();

                trbpuani = trbpuani++;
                trbpuan.Text = trbpuani.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label18.Text = a.ToString();
            label20.Text = b.ToString();
            label21.Text = c.ToString();
            label23.Text = d.ToString();

            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label20.Text))
            {
                gspuani = gspuani + 3;
                gspuan.Text = gspuani.ToString();

            }
            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label18.Text))
            {
                bjkpuani = bjkpuani + 3;
                bjkpuan.Text = bjkpuani.ToString();

            }
            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label20.Text))
            {
                gspuani = gspuani++;
                gspuan.Text = gspuani.ToString();

                bjkpuani = bjkpuani++;
                bjkpuan.Text = bjkpuani.ToString();
            }


            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label23.Text))
            {
                fbpuani = fbpuani + 3;
                fbpuan.Text = fbpuani.ToString();

            }
            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label21.Text))
            {
                trbpuani = trbpuani + 3;
                trbpuan.Text = trbpuani.ToString();
            }
            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label23.Text))
            {
                fbpuani = fbpuani++;
                fbpuan.Text = fbpuani.ToString();

                trbpuani = trbpuani++;
                trbpuan.Text = trbpuani.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label26.Text = a.ToString();
            label17.Text = b.ToString();
            label30.Text = c.ToString();
            label33.Text = d.ToString();


            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label17.Text))
            {
                fbpuani = fbpuani + 3;
                fbpuan.Text = fbpuani.ToString();

            }
            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label26.Text))
            {
                bjkpuani = bjkpuani + 3;
                bjkpuan.Text = bjkpuani.ToString();

            }
            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label26.Text))
            {
                bjkpuani = bjkpuani++;
                fbpuani = fbpuani++;
                fbpuan.Text = fbpuani.ToString();
                bjkpuan.Text = bjkpuani.ToString();
            }


            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label33.Text))
            {
                trbpuani = trbpuani + 3;
                trbpuan.Text = trbpuani.ToString();

            }
            if (Convert.ToInt32(label33.Text) > Convert.ToInt32(label30.Text))
            {
                gspuani = gspuani + 3;
                gspuan.Text = gspuani.ToString();
            }
            if (Convert.ToInt32(label30.Text) == Convert.ToInt32(label33.Text))
            {
                gspuani = gspuani++;
                gspuan.Text = gspuani.ToString();

                trbpuani = trbpuani++;
                trbpuan.Text = trbpuani.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gspuan.Text) > Convert.ToInt32(fbpuan.Text) && Convert.ToInt32(gspuan.Text) > Convert.ToInt32(trbpuan.Text) && Convert.ToInt32(gspuan.Text) > Convert.ToInt32(bjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Nur\Desktop\LVBEL C5 - '10 numara, (1).mp3";
            }
        }
    }
}

