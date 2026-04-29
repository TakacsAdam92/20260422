using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20260422
{
    internal class Auto
    {
        int Sorszam;
        string Marka;
        string Modell;
        int Gyartasi_ev;
        string Szin;
        int Eladottdb;
        double AtlageladasiAr;

        public Auto(int sorszam, string marka, string modell, int gyartasi_ev, string szin, int eladottdb, double atlageladasiAr)
        {
            Sorszam = sorszam;
            Marka = marka;
            Modell = modell;
            Gyartasi_ev = gyartasi_ev;
            Szin = szin;
            Eladottdb = eladottdb;
            AtlageladasiAr = atlageladasiAr;
        }

        public int Sorszam1 { get => Sorszam; set => Sorszam = value; }
        public string Marka1 { get => Marka; set => Marka = value; }
        public string Modell1 { get => Modell; set => Modell = value; }
        public int Gyartasi_ev1 { get => Gyartasi_ev; set => Gyartasi_ev = value; }
        public string Szin1 { get => Szin; set => Szin = value; }
        public int Eladottdb1 { get => Eladottdb; set => Eladottdb = value; }
        public double AtlageladasiAr1 { get => AtlageladasiAr; set => AtlageladasiAr = value; }

        public static List<Auto> beolvas(string fnev)
        {
           List<Auto> autoLista = new List<Auto>();
           string[] sorok = File.ReadAllLines("fnev");
           return autoLista;
        }
    }
}
