using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    public class BangunDatar
    {
        protected int panjang;
        protected int tinggi;
        private string name = "Applikasi Luas Bangun Datar";

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual void InputLuas(int panjang, int tinggi)
        {
            Console.WriteLine($"Menghitung {name}");
            Console.WriteLine("Panjang : " + panjang);
            Console.WriteLine("Tinggi  : " + tinggi);
        }

        public virtual void Hitung()
        {
            Console.WriteLine("Ini method Hitung() punya Class BangunDatar");
        }
        
        protected void ResetValue()
        {
        panjang = 0;
        tinggi = 0;
    }
    }
}
