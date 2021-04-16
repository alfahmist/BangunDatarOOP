using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class PersegiPanjang : BangunDatar
    {
        private string name = "Luas Persegi Panjang";
        protected int luas;
        public override void InputLuas(int panjang, int tinggi)
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} : {luas}");
                Console.ResetColor();
            }
            ResetValue();
        }

    }
}
