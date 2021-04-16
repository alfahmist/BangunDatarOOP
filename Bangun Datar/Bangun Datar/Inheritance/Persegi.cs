using System;
using System.Collections.Generic;
using System.Text;
using Bangun_Datar;

namespace Bangun_Datar.Inheritance
{
    public class Persegi : BangunDatar
    {
        
        private string name = "Persegi";
        private int luas;
        private int keliling;

        public override string GetName()
        {
            return this.name;
        }

        public override void InputValue(int panjang, int tinggi)
        {
            this.panjang = panjang;
            this.tinggi = tinggi;
        }

        public override void Hitung()
        {
            if (panjang == tinggi)
            {
                luas = panjang * tinggi;
                keliling = panjang * 4;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Luas {name} : {luas}");
                Console.WriteLine($"Keliling {name} : {keliling}");
                Console.ResetColor();
            }
            else
            {
                MainMenu menu = new MainMenu();
                menu.ErrorMessage("Bukan Persegi");
            }

            ResetValue();
        }
    }
}
