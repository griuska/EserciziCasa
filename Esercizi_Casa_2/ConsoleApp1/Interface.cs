using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Interface
    {

        public static void Menu()
        {
            Person.ListStatus();

            Console.WriteLine("How would you save your data? (memory | file)");
            string savemethod = Console.ReadLine();

            Console.WriteLine("Insert name");
            string name = Console.ReadLine();

            Console.WriteLine("Insert surname");
            string surname = Console.ReadLine();


            Console.WriteLine("Insert birthdate");
            string birthdate = Console.ReadLine();

            Person.MakeLine(savemethod, name, surname, birthdate);
        }

        public static void Main()
        {
            while (true)
            {
                Person.ListStatus();

                Console.WriteLine("Type 1 and press enter to add a new person data");
                Console.WriteLine("Type 2 and press enter to remove a person data");
                Console.WriteLine("Type 3 and press enter to close application");

                string input = Console.ReadLine();

                

                if (input == "1")
                {
                    Console.Clear();
                    Menu();
                }

                else if (input == "2")
                {
                    Console.Clear();
                    Person.ListStatus();
                    Person.RemoveFromList();
                }

                else if (input == "3")
                {
                    Environment.Exit(0);
                }

            }

        }

        
    }
}
