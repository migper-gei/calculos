﻿using System;
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

            double t1 =conversoes.ConverterTemperatura(conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = conversoes.ConverterTemperatura(conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"100º Fahrenheit = {t2}º Celsius");


            Console.ReadKey(); 
        }
    }
}
