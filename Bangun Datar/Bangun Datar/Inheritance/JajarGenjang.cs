using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class JajarGenjang : BangunDatar
    {
        private string name = "Jajar Genjang";
        protected int luas;
        private int keliling;
        private int sisiMiring;
        public override string GetName()
        {
            return this.name;
        }

        public void InputValue(int alas, int tinggi, int sisiMiring)
        {
            this.panjang = alas;
            this.tinggi = tinggi;
            this.sisiMiring = sisiMiring;
        }
        protected override void ResetValue()
        {
            panjang = 0;
            tinggi = 0;
            sisiMiring = 0;
        }

        public override void Hitung()
        {
            luas = panjang * tinggi;
            keliling = 2 * (panjang + sisiMiring);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Luas {name} : {luas}");
            Console.WriteLine($"Keliling {name} : {keliling}");
            Console.ResetColor();
            ResetValue();
        }
    }
}
