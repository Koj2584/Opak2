using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zamestnanec z;

        private void button1_Click(object sender, EventArgs e)
        {
            z = new Zamestnanec("Ing.","kuba Vomela", 72000,DateTime.Parse("26.2.2021"));
            MessageBox.Show(z.ToString());
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                z.ZvysOsobn(int.Parse(textBox1.Text));

                MessageBox.Show(z.ToString());
            } catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                z.PridejHodiny(int.Parse(textBox2.Text));

                MessageBox.Show(z.ToString());
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                z.Relaxace(int.Parse(textBox3.Text));

                MessageBox.Show(z.ToString());
            }
            catch
            {

            }
        }

        // Příklad 4

        SportovecProfesional sp;

        private void button8_Click(object sender, EventArgs e)
        {
            sp = new SportovecProfesional("Jakub Vomela", 0.86, 175, DateTime.Parse("26.2.2017"), 90);
            MessageBox.Show(sp.ToString());
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Trenuj(int.Parse(textBox6.Text));

                MessageBox.Show(sp.ToString());
            }
            catch
            {

            }
        }
    }
}
