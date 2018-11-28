using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            int ghiceste;
            bool run = false;
            Random n = new Random();
            int numar = 50;


            while (!run)
            {
                try
                {
                    Console.WriteLine("Ghiceste Numarul : ");
                    ghiceste = Convert.ToInt32(Console.ReadLine());

                    if ( ghiceste == numar )
                    {
                        Console.WriteLine("Ai ghicit!");
                        run = true;
                    }
                    else if ( ghiceste < numar)
                    {
                        Console.WriteLine("Numarul este prea mic");
                
                    }
                    else if ( ghiceste > numar)
                    {
                        Console.WriteLine("Numarul este prea mare");
                    }
                }

                catch(FormatException fEx)
                {
                    Console.WriteLine("Trebuie sa introduci un numar, domnule ");
                }
            }
        }
    }
}
