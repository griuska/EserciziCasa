using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Casa_2
{
    class Program
    {
        public static string CreateIp()
        {

            int[] ipnumber = {192, 168, 0, 1, };
            string riga = String.Join(".", ipnumber);
            Console.WriteLine(riga);

        }

        static void Main(String[] args)
        {

            CreateIp();
            
        }
    }
}
