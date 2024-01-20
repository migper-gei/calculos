using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa operações de conversão
    /// </summary>
    internal static class conversoes
    {
        /// <summary>
        /// tipo de conversão de temperatura a executar 
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius,
        }

        /// <summary>
        /// conversão de temperaturas
        /// </summary>
        /// <param name="conversao">A conversãoa a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);

            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura - 32) / 1.8000;
            }
            return -1;
        }


    }
}
