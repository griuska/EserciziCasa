using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Lamp
{
    public class Operations
    {

        public static string newinput;

        public static void AddBulb()

        {

            Console.WriteLine("How many bulbs are going to be created?");

            int i; string input = Console.ReadLine();
            bool result = int.TryParse(input, out i);

            if (i == 0)
            {
                Console.Clear();
            }

            else

            {
                for (int n = 1; n <= i; n++)
                {
                    Console.WriteLine($"Insert roomname for bulb {n}");
                    newinput = Console.ReadLine();

                    while(true)
                    {
                        if (newinput == null || newinput == String.Empty)
                        {
                            Console.WriteLine("Incorrect name");
                            newinput = Console.ReadLine();
                        }
                        else
                            break;
                    }

                    Menu.lightbulbsOff.Add(newinput);

                    

                    CheckDup();

                    //Console.WriteLine($"bulb {n} on or off?");
                    //string newinput2 = Console.ReadLine();

                    //while (true)
                    //{
                    //    if (newinput2 == "on" || newinput2 == "off")
                    //    {
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Type in 'on' or 'off'");
                    //        newinput2 = Console.ReadLine();
                    //    }
                    //}
                    
                    //{ Menu.lightbulbsOff.Add(newinput); }

                }

                Console.Clear();

            }
        }

        public static void CheckDup()
        {

            for (int i = 0; i < Menu.lightbulbsOff.Count; i++)
            {
               if (Menu.lightbulbsOff[i].Contains(newinput))
               {
                    Menu.lightbulbsOff.Remove(newinput);
                    Console.WriteLine("Duplicate, change name");
                    string newname = Console.ReadLine();
                    
                    Menu.lightbulbsOff.Add(newname);
                    break;
                }
               
            }
        }

        public static void ListBulbOn()
        {
            Console.WriteLine("Lightbulbs on:");
            for (int i = 0; i < Menu.lightbulbsOn.Count; i++)
            {
                Console.WriteLine($"- {i+1} " + Menu.lightbulbsOn[i]);
                Console.WriteLine();
            }                                   
        }

        public static void ListBulbOff()
        {
            Console.WriteLine("Lightbulbs off:");           
            for (int i = 0; i < Menu.lightbulbsOff.Count; i++)
            {
                Console.WriteLine($"- {i+1}" + Menu.lightbulbsOff[i]);
                Console.WriteLine();
            }
        }

        public static void DelBulb()
        {
            Console.WriteLine("Type bulbname to delete");

            string name = Console.ReadLine();

            Menu.lightbulbsOn.Remove(name);
            Menu.lightbulbsOff.Remove(name);

            Console.Clear();
        }

        public static void BulbOn()
        {
            Console.WriteLine("Type bulbname to switch on:");

            string name = Console.ReadLine();

            Menu.lightbulbsOn.Add(name);
            Menu.lightbulbsOff.Remove(name);

            Console.Clear();
        }

        public static void BulbOff()
        {
            Console.WriteLine("Type bulbname to switch off:");

            string name = Console.ReadLine();

            Menu.lightbulbsOn.Remove(name);
            Menu.lightbulbsOff.Add(name);

            Console.Clear();
        }

    }

}
