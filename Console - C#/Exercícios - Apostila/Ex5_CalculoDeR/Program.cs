using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_CalculoDeR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 5
             * 
             * Calcule valor de R, exibindo-o em vídeo.
             * 
             * X = B³ * H
             * R = X / J
             */

            double X, B, H, R, J;

            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de H: ");
            H = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de J: ");
            J = double.Parse(Console.ReadLine());

            X = Math.Pow(B, 3) * H;
            R = X / J;

            Console.WriteLine("\nO valor de R é " + R);
            Console.ReadKey();
        }
    }
}