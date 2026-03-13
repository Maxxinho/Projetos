using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int media;

            Console.WriteLine("Digite a primeira nota");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = int.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3)/3;

            if (media >= 7)
            {
                Console.WriteLine("Aluno foi aprovado ");
            }
            else {
                Console.WriteLine("Aluno foi reprovado ");
            }

        }
    }
}
