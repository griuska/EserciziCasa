using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Lamp
{
    class Menu
    {
        public static List<string> lightbulbsOn = new List<string>();
        public static List<string> lightbulbsOff = new List<string>();

        static void Main()
        {
            

            

            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("=                 LIGHTBULB MANAGER                =");
            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("There are no lightbulbs, insert first room to be lighten up");
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == String.Empty)
                {
                    Console.WriteLine("Try again");
                    
                }
                else
                {
                    lightbulbsOff.Add(input);
                    break;
                }
            }

            Console.Clear();

            Console.WriteLine("Added " + lightbulbsOff[0] + " to lightbulb pool.");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Actual ON lightbulbs:");
                for (int i = 0; i < lightbulbsOn.Count; i++)
                {
                    Console.WriteLine("- " + lightbulbsOn[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Total: " + lightbulbsOn.Count);
                Console.WriteLine();

                Console.WriteLine("Actual OFF lightbulbs");
                for (int i = 0; i < lightbulbsOff.Count; i++)
                {
                    Console.WriteLine("- " + lightbulbsOff[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Total: " + lightbulbsOff.Count);
                Console.WriteLine();

                Console.WriteLine(":: 1 :: Add Lihtbulb");
                Console.WriteLine(":: 2 :: Turn Lightbulb On");
                Console.WriteLine(":: 3 :: Turn Lightbulb Off");
                Console.WriteLine(":: 4 :: Remove Lightbulb");
                Console.WriteLine(":: 5 :: Quit program");
                Console.WriteLine("Type your choice NUMBER and press ENTER:");
                Console.WriteLine();

                var choose = Console.ReadLine();               

                if (choose == "1")
                {
                    Operations.AddBulb();
                }

                else if (choose == "2")
                {
                    Console.Clear();
                    Operations.ListBulbOff();
                    Operations.BulbOn();
                }

                else if (choose == "3")
                {
                    Console.Clear();
                    Operations.ListBulbOn();                   
                    Operations.BulbOff();
                }

                else if (choose == "4")
                {
                    Operations.ListBulbOn();
                    Operations.ListBulbOff();
                    Operations.DelBulb();
                }

                else if (choose == "5")
                {
                    Environment.Exit(0);
                }

                else
                    {
                        Console.Clear();
                    }
            }


        }
    }
}
