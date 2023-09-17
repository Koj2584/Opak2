using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opak2
{
    internal class SportovecProfesional : SportovecAmater
    {
        private DateTime vznik;
        double bazal;
        int vykonost;

        public int Vykonost
        {
            get {
                if (vykonost == 0)
                    MessageBox.Show("Neproběhla klasifikace stupně výkonosti");
                return vykonost; 
            }
            set
            {
                if(value > 0 && value <8)
                {
                    vykonost = value;
                }
                else
                    vykonost=0;
            }
        }

        public SportovecProfesional(string jmeno, double obvod, double vyska, DateTime vznik, double bazal) : base(jmeno, obvod, vyska)
        {
            this.vznik = vznik;
            this.bazal = bazal;
        }

        public bool NarokNaSlevu()
        {
            if (((DateTime.Now - vznik).Days / 365) >= 5)
                return true;
            return false;
        }
        public override void Trenuj(int hodin2)
        {
            base.Trenuj(hodin2);
            if (hodin > 100)
            {
                bazal *= 1.1;
                hodin = 0;
            }
        }
        public override string ToString()
        {
            return base.ToString() + ", Datum vzniku: " + vznik.ToString("d") + ", Bazální metabolismus: " + bazal + 
                ", Nárok na slevu: " + (NarokNaSlevu() ? "Ano":"Ne");
        }
    }
}
