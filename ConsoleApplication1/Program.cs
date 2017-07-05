using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                StartMenu();
            }
        }
        static void StartMenu()
        {
            string menu = null;
            var player = FileHandler.ReadPlayers();
            var subs = FileHandler.ReadSubs();
            do
            {
                Console.Clear();
                Console.WriteLine("***Kézilabda szimuláció***");
                Console.Write("1: :szimuláció futtatása\n\n2:kilépés\nParancs: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        var match = new Match(player, subs);
                        match.PlayerMatch();
                        //Display(Player[] players);

                        Console.WriteLine("\n\n\nÜss le egy billentyűt a kilépéshez...");
                        Console.ReadKey();
                        break;
                   
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Rossz parancs...");
                        Thread.Sleep(500);
                        break;
                }


            } while (menu != "2");

        }
    }
}
