using Bangun_Datar.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    public class MainMenu
    {
        BangunDatar bangunDatar = new BangunDatar();
        Persegi persegi = new Persegi();
        PersegiPanjang persegiPanjang = new PersegiPanjang();
        Segitiga segitiga = new Segitiga();
        Lingkaran lingkaran = new Lingkaran();
        JajarGenjang jajarGenjang = new JajarGenjang();

        string NamaApplikasi;
        public bool restart = true;
        string yes;
        
        public void Show(){
            int count = 1;
            NamaApplikasi = bangunDatar.GetName();
            string[] Lists = { 
                persegi.GetName(),
                persegiPanjang.GetName(),
                segitiga.GetName(),
                lingkaran.GetName(),
                jajarGenjang.GetName()
            };

            Console.WriteLine(NamaApplikasi);
            Console.WriteLine();
            foreach (string list in Lists)
            {
                Console.WriteLine($"{count}.{list}");
                count++;
            }
            Console.WriteLine("Masukkan Menu Pilihan 1 sampai 5");
        }

        public void Input(int input)
        {
            int input1;
            int input2;

            switch (input)
            {
                case 1:
                    //persegi
                    try
                    {
                        Console.Write("Masukkan Panjang : ");
                        input1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi : ");
                        input2 = Int32.Parse(Console.ReadLine());
                        persegi.InputValue(input1, input2);
                    }
                    catch (FormatException)
                    {
                       ErrorMessage("Harap Masukkan Integer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        persegi.Hitung();
                        Console.WriteLine();
                        Restart();
                    }
                    break;
                case 2:
                    // Persegi Panjang
                    try
                    {
                        Console.Write("Masukkan Panjang : ");
                        input1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi : ");
                        input2 = Int32.Parse(Console.ReadLine());
                        persegiPanjang.InputValue(input1, input2);
                    }
                    catch (FormatException)
                    {
                        ErrorMessage("Harap Masukkan Integer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        persegiPanjang.Hitung();
                        Console.WriteLine();
                       
                        Restart();
                    }
                    break;
                case 3:
                    // Segitiga
                    try
                    {
                        Console.Write("Masukkan Alas : ");
                        input1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi : ");
                        input2 = Int32.Parse(Console.ReadLine());
                        segitiga.InputValue(input1, input2);
                    }
                    catch (FormatException)
                    {
                        ErrorMessage("Harap Masukkan Integer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        segitiga.Hitung();
                        Console.WriteLine();
                       
                        Restart();
                    }
                    break;
                case 4:
                    // Lingkaran
                    try
                    {
                        Console.Write("Masukkan jari jari : ");
                        input1 = Int32.Parse(Console.ReadLine());
                        lingkaran.InputValue(input1);
                    }
                    catch (FormatException)
                    {
                        ErrorMessage("Harap Masukkan Integer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        lingkaran.Hitung();
                        Console.WriteLine();         
                        Restart();
                    }
                    break;
                case 5:
                    // Jajar Genjang
                    try
                    {
                        Console.Write("Masukkan Panjang alas : ");
                        input1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi : ");
                        input2 = Int32.Parse(Console.ReadLine());     
                        Console.Write("Masukkan Sisi Miring : ");
                        int input3 = Int32.Parse(Console.ReadLine());
                        jajarGenjang.InputValue(input1, input2, input3);
                    }
                    catch (FormatException)
                    {
                        ErrorMessage("Harap Masukkan Integer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        jajarGenjang.Hitung();
                        Console.WriteLine();
                     
                        Restart();
                    }
                    break;
                default:
                    ErrorMessage("Harap Masukkan angka 1 sampai 5");
                    Console.Clear();
                    break;
            }
        }

        public void Restart()
        {
            Console.WriteLine("Restart Program ? Type Yes to restart");
            yes = Console.ReadLine();
            if(yes.ToLower() == "yes")
            {
                this.restart = true;
                Console.Clear();
            }
            else
            {
                this.restart = false;
            }
        }

        public void ErrorMessage(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR : {m}");
            Console.ResetColor();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }
}
