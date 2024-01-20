using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4+2={aritmetica.somar(4,2)}");
            Console.WriteLine($"4-2={aritmetica.subtrair(4, 2)}");

            Console.ReadKey();
        }
    }
}
