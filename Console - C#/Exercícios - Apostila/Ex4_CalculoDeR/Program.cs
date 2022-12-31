using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_CalculoDeR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 4
             * 
             * Calcule valor de R, exibindo-o em vídeo.
             *
             * R = B² - (C * D) 
             */

            double R, B, C, D;

            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            D = double.Parse(Console.ReadLine());

            R = Math.Pow(B, 2) - (C * D);

            Console.WriteLine("\nO valor de R é: " + R);
            Console.ReadKey();
        }
    }
}