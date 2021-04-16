using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class Lingkaran : BangunDatar
    {
        private string name = "Luas Lingkaran";
        private const double pi = 3.14;
        protected double luas;

        public override string GetName()
        {
            return this.name;
        }

        // Overloading
        public void InputLuas(int jari)
        {
            this.panjang = jari;
        }

        public override void Hitung()
        {
            luas = pi * (Math.Pow(panjang,2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{name} : {luas}");
            Console.ResetColor();
            ResetValue();
        }
    }
}
