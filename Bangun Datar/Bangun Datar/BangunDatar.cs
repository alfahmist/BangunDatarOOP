using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    public class BangunDatar : IBangunDatar
    {
        protected int panjang;
        protected int tinggi;
        protected double luas;
        protected double keliling;
        private string name = "Applikasi Menghitung Bangun Datar";

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual void InputValue(int panjang, int tinggi)
        {
            Console.WriteLine($"Menghitung {name}");
            Console.WriteLine("Panjang : " + panjang);
            Console.WriteLine("Tinggi  : " + tinggi);
        }

        public virtual void Hitung()
        {
            Console.WriteLine("Ini method Hitung() punya Class BangunDatar");
        }
        
        protected virtual void ResetValue()
        {
        panjang = 0;
        tinggi = 0;
        }
    }
}
