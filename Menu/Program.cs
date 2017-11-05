using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class CustomMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("=                LIGHT BULB MANAGER                =");
            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();

            Pool.pool();

            Console.WriteLine();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine(":: Add Lihtbulb (1) :: Turn Lightbulb On (2) :: Turn Lightbulb Off (3) ::");
                Console.WriteLine("Type your choice:");
                Console.WriteLine();

                var input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    Console.WriteLine("ok");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                }

            }


        }
    }
}
