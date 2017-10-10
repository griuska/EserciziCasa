using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WindowWidth = 200;
            Console.WindowHeight = 10;

            Console.WriteLine("dimmi quanti slots");
            int slots = int.Parse(Console.ReadLine());

            int[] array1 = new int[slots];
            int n; int sum = 0;
            for (n = 0; ;)
            {
                if (n < slots)
                {
                    Console.WriteLine("slot" + n);
                    array1[n] = int.Parse(Console.ReadLine());
                    sum = sum + array1[n];
                    n++;
                }
                else
                    break;

            }


            Console.WriteLine("Adesso facciamo la somma: " + sum);

            Console.ReadLine();

        }
    }
}
