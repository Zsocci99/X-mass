using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace X_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            nstart:
            Console.WriteLine("Milyen havazást szeretnél?");
            Console.WriteLine("1 Szállingózás");
            Console.WriteLine("2 Havazás");
            Console.WriteLine("3 Hóvihar");
            string válasz = Console.ReadLine();
            Console.Clear();


            if (válasz != "1" && válasz != "2" && válasz != "3")
            {
                Console.WriteLine("A megadott válasz nem 1 vagy 2 vagy 3!");
                Console.ReadKey();
                Console.Clear();
                goto nstart;
            }
            else
                Console.ForegroundColor = ConsoleColor.White;
            int valasz = Convert.ToInt32(válasz);
            
            int x = Console.WindowLeft;
            int y = Console.WindowTop;
            Random rnd = new Random();
            
            do{
                for (int u = 0; u < Console.WindowHeight; u++)
                {
                start:
                    switch (valasz)
                    {
                        case 1:
                            x = rnd.Next(5, 25);
                            break;
                        case 2:
                            x = rnd.Next(3, 13);
                            break;
                        case 3:
                            x = rnd.Next(1, 5);
                            break;
                        default:
                            Console.WriteLine("Walamit nagyon elcsesztél! XD");
                            break;
                    }

                    for (int i = 0; i < Console.WindowWidth; i++)
                    {
                        if (x >= Console.WindowWidth -1)
                        {
                            Console.SetCursorPosition(Console.WindowWidth - 1, y);
                            break;
                        }
                        else
                        {
                    if(y >= 299)
                    {
                        Console.Clear();
                        y = 0;
                        break;
                    }
                            Console.SetCursorPosition(x, y);
                            Console.Write("*");
                            switch (valasz)
                            {
                                case 1:
                                    x += rnd.Next(5, 25);
                                    break;
                                case 2:
                                    x += rnd.Next(3, 13);
                                    break;
                                case 3:
                                    x += rnd.Next(1, 5);
                                    break;
                                default:
                                    Console.WriteLine("Walamit nagyon elcsesztél! XD");
                                    break;
                            }
                            

                        }
                    }

                    Thread.Sleep(1000);
                    Console.SetCursorPosition(Console.WindowLeft,Console.WindowTop);
                    Console.WriteLine();
                    y++;
                    goto start;
                }
            }
                while(true);
        }
    }
}
