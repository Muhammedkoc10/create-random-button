using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sayilar = new ArrayList();
        
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                int uretilenSayi = rnd.Next(20, 80);
                if (sayilar.IndexOf(uretilenSayi) == -1)
                {
                    Button buton = new Button();
                    buton.Width = 30;
                    buton.Height = 30;
                    buton.Text = uretilenSayi.ToString();
                    flpButon.Controls.Add(buton);
                    sayilar.Add(uretilenSayi);
                }
                else
                    i--;
            }
        }

        private void rbTek_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Button item in flpButon.Controls)
            {
                int butonSayi = Convert.ToInt32((item as Button).Text);

                if (butonSayi %2 != 0)
                    (item as Button).Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Button item in flpButon.Controls)
            {
                int butonSayi = Convert.ToInt32((item as Button).Text);

                if (butonSayi % 2 == 0)
                    (item as Button).Enabled = false;

            }
        }
    }
}
