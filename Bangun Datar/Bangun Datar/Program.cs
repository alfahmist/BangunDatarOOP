using Bangun_Datar.Inheritance;
using System;

namespace Bangun_Datar
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            MainMenu menu = new MainMenu();
            BangunDatar bangunDatar = new BangunDatar();
            Persegi persegi = new Persegi();
            PersegiPanjang persegiPanjang = new PersegiPanjang();
            Segitiga segitiga = new Segitiga();
            Lingkaran lingkaran = new Lingkaran();
            JajarGenjang jajarGenjang = new JajarGenjang();

            while(menu.restart)
            {            
                menu.Show();
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                    menu.Input(input);
                } catch(FormatException)
                {
                    menu.ErrorMessage("Harap Masukkan Integer");
                    Console.Clear();
                }
            }

        }
    }
}
