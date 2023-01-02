using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 3
             * 
             * Calcule a seguinte fórmula: (C# e fluxograma)
             * 
             * X = b / m.
             * 
             * Se m = 0, você não deve efetuar a divisão. E deve exibir um erro na tela.
             * Ao final, mostre o  valor de x.
             */

            double x, b, m;
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de m: ");
            m = Convert.ToDouble(Console.ReadLine());

            if (m != 0)
            {
                x = b / m;
                Console.WriteLine("Resultado: {0}", x);
            }
            else
                Console.WriteLine("M não pode ser zero!");

            Console.ReadKey();
        }
    }
}