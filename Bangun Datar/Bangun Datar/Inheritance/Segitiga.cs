using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class Segitiga : BangunDatar
    {
        private string name = "Segitiga Siku Siku";
        private double sisiMiring;

        public override string GetName()
        {
            return this.name;

        }
        public override void InputValue(int alas, int tinggi)
        {
            this.panjang = alas;
            this.tinggi = tinggi;
        }

        public override void Hitung()
        {
            sisiMiring = Math.Sqrt(Math.Pow(panjang, 2) + Math.Pow(tinggi, 2));
            double rumusSegitiga = (panjang * tinggi) / 2;
            luas = Math.Round(rumusSegitiga,2);
            keliling = Math.Round((panjang + tinggi + sisiMiring),2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sisi Miring: {sisiMiring}");
            Console.WriteLine($"Luas {name} : {luas}");
            Console.WriteLine($"Keliling {name} : {keliling}");
            Console.ResetColor();
            ResetValue();

        }
    }
}
