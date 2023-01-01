using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_ContagemIntervalos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe diversos valores e o programa mostrará quantos deles");
            Console.WriteLine("estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [75-100].\n");

            double quantidade, n = 1, int1 = 0, int2 = 0, int3 = 0, int4 = 0;

            //Solicitando a quantidade de números que o usuário vai informar
            Console.WriteLine("Quantos números deseja informar?");
            quantidade = Convert.ToDouble(Console.ReadLine());

            //Laço de repetição a partir da quantidade de números 
            for (int i = 1; i <= quantidade; i++)
            {
                //Solicitando os números 
                Console.Write("\n" + i + "° número: ");
                n = Convert.ToDouble(Console.ReadLine());

                //Condição para números positivos
                if (n < 0)
                {
                    Console.WriteLine("\nOps! Não pode informar um número negativo. Reinicie o programa.");
                    break;
                }

                //Condição do intervalo de 0 até 25
                if (n >= 0 && n <= 25)
                    int1++;

                //Condição do intervalo de 26 até 50
                if (n > 25 && n <= 50)
                    int2++;

                //Condição do intervalo de 51 até 75
                if (n > 50 && n <= 75)
                    int3++;

                //Condição do intervalo de 76 até 100
                if (n > 75 && n <= 100)
                    int4++;
            }

            if (n >= 0)
            {
                //Imprimindo na tela do usuário
                Console.WriteLine($"\nA quantidade de números entre [0-25] é {int1}");
                Console.WriteLine($"A quantidade de números entre [26-50] é {int2}");
                Console.WriteLine($"A quantidade de números entre [51-75] é {int3}");
                Console.WriteLine($"A quantidade de números entre [76-100] é {int4}");
            }

            Console.ReadKey();
        }
    }
}