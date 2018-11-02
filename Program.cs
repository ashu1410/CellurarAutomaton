using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatKomórkowy
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int iterations, numberofcells, rule;
            try
            {
                Console.Write("Rozmiar przestrzeni   ");
                input = Console.ReadLine();
                Int32.TryParse(input, out numberofcells);
                Console.Write("Liczba iteracji ");
                input = Console.ReadLine();
                Int32.TryParse(input, out iterations);
                Console.Write("Numer reguly (0-255) ");
                input = Console.ReadLine();
                Int32.TryParse(input, out rule);
                if (rule < 0 || rule > 255)
                    throw new Exception();

                Console.Clear();
                Automat1D automat = new Automat1D(numberofcells);
                automat.Iterate(iterations, rule);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cos sie popsulo!");
                Console.ReadKey();
            }


        }
    }
}
