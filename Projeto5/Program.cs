using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int total;

            Console.WriteLine("Digite o valor");
            valor1 = int.Parse(Console.ReadLine());
            total = valor1 * 2;
            Console.WriteLine("O dobro deste numero é "+total);
        }
    }
}
