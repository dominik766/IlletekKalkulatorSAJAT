using System;
using System.Collections.Generic;
using System.Text;

namespace illetekKalkulator
{
    internal class Szoba
    {
        // belső tárolók
        private int ejszakaiAr;
        private int ferohely;
        private static int osszesRegisztraltSzoba = 0;
        // properties
        public string Szobaszam { get; set; }
        public int Emelet {  get; set; }
        public int EjszakaiAr
        {
            //belső tárolóbol szedi
            get => ejszakaiAr;
            // ha kisebb mint 0, automatikusan állitsa 0-ra
            set => ejszakaiAr = value < 0 ? 0 : value;
            // ejszakaiAr = if value kisebb mint 0;
            // ? igaz feltételezés : hamis feltételezés
        }
        public int Ferohely
        {
            get => ferohely;
            set => ferohely = value < 1 ? 1 : value;
        }
        public int OsszesRegisztraltSzoba
        {
            get => osszesRegisztraltSzoba;
        }
        // konstruktor láncolás!!! (: this(paraméterek magukban))
        // alap férőhely: 2
        public Szoba(string szobaszam, int emelet, int ejszakaiAr) : this(szobaszam, emelet, ejszakaiAr, 2)
        {

        }
        public Szoba(string szobaszam, int emelet, int ejszakaiAr, int ferohely)
        {
            Szobaszam = szobaszam;
            Emelet = emelet;
            EjszakaiAr = ejszakaiAr;
            Ferohely = ferohely;
            osszesRegisztraltSzoba++;
        }
        // alap kiirás "Console.WriteLine()"
        public override string ToString()
        {
            return ($"{Szobaszam} Emelet: {Emelet} | Férőhely: {Ferohely} fő | Ár: {EjszakaiAr} Ft/éj");
        }
    }
}
