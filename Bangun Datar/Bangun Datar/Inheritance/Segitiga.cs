using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class Segitiga : BangunDatar
    {
        private string name = "Luas Segitiga Siku Siku";
        protected double luas;
        public override string GetName()
        {
            return this.name;

        }
        public override void InputLuas(int alas, int tinggi)
        {
            this.panjang = alas;
            this.tinggi = tinggi;
        }

        public override void Hitung()
        {
            luas = (panjang * tinggi)/2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{name} : {luas}");
            Console.ResetColor();
            ResetValue();

        }
    }
}
