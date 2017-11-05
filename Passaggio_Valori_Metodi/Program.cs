using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passaggio_Valori_Metodi
{
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine("Primo Metodo: " + x);
        }

        private static void Main(String[] args)
        {
            int i = 100;
            Console.WriteLine("prima del cambiamento" + i);
            ChangeValue(i);
            Console.WriteLine("dopo il cambiamento" + i);
        }
    }
}
