using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        static string _savemethod;
        static string _name;
        static string _surname;
        static string _birthdate;

        static List<List<string>> AccountList = new List<List<string>>();


        public static void MakeLine(string savemethod, string name, string surname, string birthdate)
        {
            _savemethod = savemethod;
            _name = name;
            _surname = surname;
            _birthdate = birthdate;

            string summary = ("Name: " + _name + " Surname: " + _surname + " born in " + _birthdate + ".");
            Console.WriteLine(summary);

            Console.WriteLine("Correct?");
            string confirm = Console.ReadLine();

            if (confirm == "yes")
            {
                
            }
            else
            {
                Console.Clear();
                Interface.Menu();
            }

        }

        public static void AddToList()
        {
            if (_savemethod == "memory")
            {
                AccountList.Add(new List<string> { _name, _surname, _birthdate });
                Console.WriteLine("Ok");
                Interface.Main();
            }
            else
            {
                // File.WriteAllLines(@"C:\temp\selectedDays.txt", JulyWeekends);
            }
            
        }

        public static void RemoveFromList()
        {
            ListStatus();
            Console.WriteLine("Who's going to be removed from list?");
            string input = Console.ReadLine();

            

            AccountList.Remove(new List<string> { _name, _surname, _birthdate });

            Interface.Menu();
        }

        public static void ListStatus()
        {


            for (int i = 0; i < AccountList.Count(); i++)
            {

                
                Console.ReadLine();
            }

        }


    }

}
