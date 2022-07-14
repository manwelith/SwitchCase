using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = { "pazartesi", "salı", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    {
                        Console.WriteLine(gunler[0]);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(gunler[1]);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(gunler[2]);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(gunler[3]);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(gunler[4]);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(gunler[5]);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(gunler[6]);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error.");
                        break;
                    }
            }


            Console.ReadLine();

        }
    }
}
