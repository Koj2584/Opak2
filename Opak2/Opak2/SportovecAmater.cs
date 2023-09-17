using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opak2
{
    internal class SportovecAmater
    {
        protected string jmeno;
        protected int hodin;
        double obvod;
        double vyska;

        public double Obvod
        {
            get { return Math.Round(obvod,0); }
            set
            {
                if(value < 5)
                {
                    obvod = value*100;
                }
                else if (value >= 0)
                    obvod = value;
                else
                    MessageBox.Show("Chyba. Záporné číslo!!");
            }
        }

        public double Vyska
        {
            get { return Math.Round(vyska,0); }
            set
            {
                if (value < 5)
                {
                    vyska = value * 100;
                }
                else if (value >= 0)
                    vyska = value;
                else
                    MessageBox.Show("Chyba. Záporné číslo!!");
            }
        }


        public SportovecAmater(string jmeno, double obvod, double vyska)
        {
            this.jmeno = jmeno;
            this.Obvod = obvod;
            this.Vyska = vyska;
            this.hodin = 0;
        }
        public double WHtR()
        {
            return obvod / vyska;
        }

        public virtual void Trenuj(int hodin2)
        {
            hodin+=hodin2;
        }

        public bool JeObezni()
        {
            if (WHtR() > 0.5778)
                return true;
            return false;
        }
        public override string ToString()
        {
            return "Jméno: " + jmeno + ", Obvod pasu: " + Obvod + ", Výška: " + Vyska + ", Počet odtrénovaných hodin: " + hodin + 
                ", Poměr: " + WHtR() + "\nJe obézní: " + (JeObezni() ? "Ano" : "Ne");
        }
    }
}
