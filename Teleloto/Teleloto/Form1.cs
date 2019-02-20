using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuoti_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            TextBox[] Melyni = { M1, M2, M3, M4, M5 };
            TextBox[] Juodi = { J1, J2, J3, J4, J5 };
            TextBox[] Raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] Geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] Zali = { Z1, Z2, Z3, Z4, Z5 };
            GeneruotiStulpeli(rng, Melyni, 1, 16);
            GeneruotiStulpeli(rng, Juodi, 16, 31);
            GeneruotiStulpeli(rng, Raudoni, 31, 46);
            GeneruotiStulpeli(rng, Geltoni, 46, 61);
            GeneruotiStulpeli(rng, Zali, 61, 76);
        }

        private void GeneruotiStulpeli(Random rng, TextBox[] textMasyvas, int a, int b)
        {
            int i = 0;
            while (i < textMasyvas.Length)
            {
                string skaicius = rng.Next(a, b).ToString();
                bool pozymis = true;
                foreach (var item in textMasyvas)
                {
                    if (skaicius == item.Text)
                    {
                        pozymis = false;
                        break;
                    }
                }
                if (pozymis)
                {
                    textMasyvas[i].Text = skaicius;
                    i++;
                }
            }
        }

        private void Ridenti_Click(object sender, EventArgs e)
        {
            IsridentiKamuoliukai.Text = "";
            Random rng = new Random();
            int i = 0;
            List<int> isridentiKamuoliukai = new List<int>();

            while (i < 45)
            {
                int kamuoliukas = rng.Next(1, 76);
                bool pozymis = true;
                foreach (var item in isridentiKamuoliukai)
                {
                    if (item == kamuoliukas)
                    {
                        pozymis = false;
                    }
                }
                if (pozymis)
                {
                    isridentiKamuoliukai.Add(kamuoliukas);
                    PatikrintiBilieta(kamuoliukas);
                    IsridentiKamuoliukai.Text += kamuoliukas.ToString() + " ";
                    i++;
                }
            }
        }

        private void PatikrintiBilieta(int kamuoliukas)
        {
            TextBox[] Laukeliai = { M1, M2, M3, M4, M5,
            J1, J2, J3, J4, J5,
            R1, R2, R3, R4, R5,
            G1, G2, G3, G4, G5,
            Z1, Z2, Z3, Z4, Z5 };
            foreach (var item in Laukeliai)
            {
                if (item.Text == kamuoliukas.ToString())
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}