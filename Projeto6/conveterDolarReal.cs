using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto6
{
    internal class conveterDolarReal
    {
        static void Main(string[] args)
        {
            double d;
            double r;

            Console.WriteLine("Coloque o valor em dólar");
            d = double.Parse(Console.ReadLine());
            r = d * 5.2;
            Console.WriteLine("Este valor em reais é " + r);
        }
    }
}
