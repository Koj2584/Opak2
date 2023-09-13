﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opak2
{
    class Zamestnanec
    {
        string titul;
        string jmeno;
        int plat;
        DateTime nastup;
        int hodnoceni;
        string pozice;
        int odpracovane;

        string Jmeno
        {
            get
            {
                string jmeno2 = jmeno;
                if (jmeno2[0] < 'A' || jmeno2[0] > 'Z')
                {
                    jmeno2 = (char)(jmeno2[0]+('A'-'a'))+jmeno2.Substring(1);
                }
                string[] s = jmeno2.Split(' ');
                s[1] = s[1].ToUpper();
                return s[0] + ' ' + s[1];
            }
            set
            {
                jmeno = value;
            }
        }

        string Titul
        {
            get
            {
                string titul2 = titul;
                if (titul2[0] < 'A' || titul2[0] > 'Z')
                {
                    titul2 = (char)(titul2[0] + ('A' - 'a')) + titul2.Substring(1);
                }
                if (titul2[titul2.Length - 1] != '.')
                {
                    titul2 += '.';
                }
                
                return titul2;
            }
        }

        public Zamestnanec(string titul,string jmeno, int plat, DateTime nastup)
        {
            this.titul = titul;
            this.jmeno = jmeno;
            this.plat = plat;
            this.nastup = nastup;
            hodnoceni = 0;
            odpracovane = 0;
            pozice = "Zaměstnanec";
        }

        int RocniPlat()
        {
            return plat * 12;
        }

        double PocetMesicu()
        {
            TimeSpan ts = DateTime.Now - nastup;
            return ts.Days/30;
        }

        double Celkem()
        {
            return PocetMesicu() * plat;
        }

        void ZvysOsobn(int castka)
        {
            hodnoceni += castka;
            if (hodnoceni > 10000)
                pozice = "Vedoucí";
        }

        void Relaxace(int dny)
        {
            //Neńí v zadání
        }

        void PridejHodiny(int hodiny)
        {
            odpracovane += hodiny;
            if (odpracovane > 100)
            {
                odpracovane = 0;
                Relaxace(3);
            }
        }

        public override string ToString()
        {
            return Titul+", "+Jmeno+", "+plat+", "+PocetMesicu()+", "+hodnoceni+", "+RocniPlat()+", "+Celkem()+
                ", "+odpracovane;
        }
    }
}
