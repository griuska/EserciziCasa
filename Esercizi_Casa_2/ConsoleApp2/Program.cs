using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Customer Mario = new Customer();

            Customer Piero = new Customer();

            

            Mario.Name = "Mona";
            Piero.Name = "Ciao";

            Console.WriteLine("{0} nome1", Mario.Name);
            Console.WriteLine("{0} nome1", Piero.Name);
            Console.ReadLine();
            
        }

    }

    public class Customer
    {
        public string Name { get; internal set; }
    }
}
