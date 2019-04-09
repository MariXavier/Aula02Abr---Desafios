using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Soma: " + somar(numero1, numero2));
            Console.ReadKey();
        }

        public static int somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
