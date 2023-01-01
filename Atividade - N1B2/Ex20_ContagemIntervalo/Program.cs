using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_ContagemIntervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descrever quantos números estão entre 0 e 100, quantos entre 101 e 200 e quantos são maiores de 200.");

            double nummaior = 0, numEntre0e100 = 0, numEntre101e200 = 0;

            Console.WriteLine("\nDigite 20 números : \n");

            // Laço de repetição de 1 até 20
            for (int i = 1; i <= 20; i++)
            {
                double numero = 0;

                Console.Write($"{i}° número : ");
                numero = double.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    //Verificação se o número está entre 0 e 100 
                    if (numero >= 0 && numero <= 100)
                        numEntre0e100++;

                    //Verificação se o número está entre 101 e 200
                    else if (numero >= 101 && numero <= 200)
                        numEntre101e200++;

                    //Verificação se o número é maior que 200
                    else
                        nummaior++;
                }
            }

            //Exibição dos resultados
            Console.WriteLine("\nQuantidade de números entre 0 e 100 : " + numEntre0e100);
            Console.WriteLine("\nQuantidade de números entre 101 e 200 : " + numEntre101e200);
            Console.WriteLine("\nQuantidade de números maiores que 200 : " + nummaior);

            Console.ReadKey();
        }
    }
}