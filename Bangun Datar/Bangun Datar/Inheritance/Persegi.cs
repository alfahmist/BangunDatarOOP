using System;
using System.Collections.Generic;
using System.Text;
using Bangun_Datar;

namespace Bangun_Datar.Inheritance
{
    public class Persegi : BangunDatar
    {
        
        private string name = "Luas Persegi";
        protected int luas;

        public override string GetName()
        {
            return this.name;
        }


        public override void InputLuas(int panjang, int tinggi)
        {
            this.panjang = panjang;
            this.tinggi = tinggi;
        }

        public override void Hitung()
        {
            if (panjang == tinggi)
            {
                luas = panjang * tinggi;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} : {luas}");
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
