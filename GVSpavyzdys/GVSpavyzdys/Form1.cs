using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVSpavyzdys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PakeistiButton_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            Grupe.BackColor = Color.Blue;
        }

        private void TekstasMYgtukas_Click(object sender, EventArgs e)
        {
            TekstasMYgtukas.Text = TekstinisLaukas.Text;
        }
    }
}