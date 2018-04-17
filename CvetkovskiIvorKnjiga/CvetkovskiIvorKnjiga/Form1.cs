using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvetkovskiIvorKnjiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Poglavlje poglavlje1 = new Poglavlje(textBoxNaziv.Text, Convert.ToInt32(textBoxBrStr.Text));

            KnjigaControl kontrola = new KnjigaControl();
            kontrola.dodajPoglavlje(poglavlje1);
            textBoxBrStr.Clear();
            textBoxNaziv.Clear();
            textBoxNaziv.Focus(); //vraca se kursor na textBox 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KnjigaControl kontrola = new KnjigaControl();
            richTextBox1.Text = kontrola.ispisiPoglavlja();
            
        }
    }
}
