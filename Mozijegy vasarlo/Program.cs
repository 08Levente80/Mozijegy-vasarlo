using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mozijegy_vasarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Petrik Mozi ===");
            Console.WriteLine();

            Console.WriteLine("1.) Jegyvásárlás");
            Console.WriteLine("2.) Filmek");
            Console.WriteLine("3.) Kilépés");

            Console.WriteLine();
            Console.WriteLine("Válasz: ");

            try
            {
                int valasztas = Convert.ToInt32(Console.ReadLine());

                switch(valasztas)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("== Jegyvásárlás ==");
                        Console.WriteLine();
                        Console.Write("Mi a neved?: ");
                        string nev = Console.ReadLine();
                        Console.Write("Háyn éves vagy?: ");
                        int eletkor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (eletkor < 12)
                        {
                            Console.WriteLine($"Szia! {nev}");
                            Console.WriteLine("A számodra megfelelő jegy: Gyerek jegy");
                            Console.WriteLine("Fizetendő: 1500 Ft");
                        }

                        else if (eletkor < 18)
                        {
                            Console.WriteLine($"Szia! {nev}");
                            Console.WriteLine("A számodra megfelelő jegy: Diák jegy");
                            Console.WriteLine("Fizetenedő: 2000 Ft");
                        }

                        else if (eletkor < 65)
                        {
                            Console.WriteLine($"Szia! {nev}");
                            Console.WriteLine("A számodra megfelelő jegy: Felnőtt jegy");
                            Console.WriteLine("Fizetenedő: 3000 Ft");
                        }

                        else
                        {
                            Console.WriteLine($"Szia! {nev}");
                            Console.WriteLine("A számodra megfelelő jegy: Nyugdíjas jegy");
                            Console.WriteLine("Fizetenedő: 1800 Ft");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== MAI FILMEK ===");
                        Console.WriteLine();
                        Console.WriteLine("1.) Minecraft film");
                        Console.WriteLine("2.) Bosszúállók");
                        Console.WriteLine("3.) Shrek");
                        Console.WriteLine();
                        Console.WriteLine("Melyik filmet választod? (add meg a film számát): ");

                        int film = Convert.ToInt32(Console.ReadLine());

                        switch(film)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("A Minecraft filmet választottad.");
                                break;

                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("A Bosszúállók filmet választottad.");
                                break;

                            case 3:
                                Console.WriteLine();
                                Console.WriteLine("A Shrek filmet választottad.");
                                break;

                            default:
                                Console.WriteLine("Nincs ilyen film.");
                                break;
                        }
                        
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Hiba! Csak számoz adhatsz meg!");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
