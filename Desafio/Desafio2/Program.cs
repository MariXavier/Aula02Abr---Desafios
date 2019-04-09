using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Século: " + centuryFromYear(ano));
            Console.ReadKey();
        }

        public static int centuryFromYear(int ano)
        {
            if (ano % 100 == 0)     { return ano / 100; }
            else                    { return (ano / 100) + 1; }
            


        }
    }
}
