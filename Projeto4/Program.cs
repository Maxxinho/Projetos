using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C;
            float F;

            Console.WriteLine("Digite o grau em Celsius");
            C = int.Parse(Console.ReadLine());
            F = C * 9 / 5 + 32;
            Console.WriteLine("A conversão para Fahrenheit é "+F);
            
            
        }
    }
}
