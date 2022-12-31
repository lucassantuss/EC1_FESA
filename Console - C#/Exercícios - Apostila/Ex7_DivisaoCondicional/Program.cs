using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_DivisaoCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 7
             * 
             * Calcule a seguinte fórmula:
             * 
             * X = b / m.
             * 
             * Se m = 0, você não deve efetuar a divisão. E deve exibir um erro na tela.
             * 
             * Ao final, mostre o valor de x.
             */

            float X, b, m;

            Console.Write("Digite o valor de b: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de m: ");
            m = float.Parse(Console.ReadLine());

            if (m == 0)
                Console.WriteLine("\n***ERRO***\n\nO valor de m deve ser diferente de 0");
            else
            {
                X = b / m;
                Console.WriteLine("\nO valor de X é: " + X);
            }

            Console.ReadKey();
        }
    }
}