using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar.Inheritance
{
    class Lingkaran : BangunDatar
    {
        private string name = "Lingkaran";
        private const double pi = 3.14;
        private double luas;
        private double keliling;

        public override string GetName()
        {
            return this.name;
        }

        // Overloading
        public void InputValue(int jari)
        {
            this.panjang = jari;
        }

        public override void Hitung()
        {
            luas = pi * (Math.Pow(panjang,2));
            keliling = Math.Round((2 * pi * panjang),2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Luas {name} : {luas}");
            Console.WriteLine($"Keliling {name} : {keliling}");
            Console.ResetColor();
            ResetValue();
        }
    }
}
