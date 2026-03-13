using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());
            total = valor1 + valor2;
            Console.WriteLine(total);
        }
    }
}
