using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class PersegiPanjang : BangunDatar
    {
        private string name = "Persegi Panjang";
        private int luas;
        private int keliling;
        public override void InputValue(int panjang, int tinggi)
        {
            this.panjang = panjang;
            this.tinggi = tinggi;
        }

        public override void Hitung()
        {
            if(panjang == tinggi && panjang != 0)
            {
                MainMenu menu = new MainMenu();
                menu.ErrorMessage("Bukan Persegi Panjang");
            } else
            {
                luas = panjang * tinggi;
                keliling = (panjang * 2) + (tinggi * 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Luas {name} : {luas}");
                Console.WriteLine($"Keliling {name} : {keliling}");
                Console.ResetColor();
            }
            ResetValue();
        }

    }
}
