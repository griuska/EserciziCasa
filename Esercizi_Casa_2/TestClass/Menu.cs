using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<string> MenuVoices = new List<string>();
            MenuVoices.Add("Attiva applicazione");
            MenuVoices.Add("Chiudi applicazione");

            int i = 1;

            foreach (string MenuVoice in MenuVoices)
            {
                Console.WriteLine(i + " " + MenuVoice);
                i++;
            }

            Console.ReadLine();
        }
    }

    

}
