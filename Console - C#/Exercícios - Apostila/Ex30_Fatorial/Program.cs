using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 30
             * 
             * FATORIAL
             * 
             * Faça um programa que solicite um número e exiba o fatorial deste número.
             * 
             * Ex:
             * 
             * 5! = 5*4*3*2*1 = 120
             * 
             * Lembre-se: pode ser também 1*2*3*4*5 = 120.
             * 
             * Não precisa ir exibindo as multiplicações. Basta exibir o valor final. 
             */

            Console.WriteLine("Digite um número: ");
            ulong numero = Convert.ToUInt64(Console.ReadLine());

            ulong fatorial = 1;

            for (ulong n = 1; n <= numero; n++)
            {
                fatorial = fatorial * Convert.ToUInt64(n);
            }

            Console.WriteLine("{0}! = {1}", numero, fatorial);
            Console.ReadLine();
        }
    }
}