using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex54_MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 54
             * 
             * MaiorMenor
             * 
             * Faça um programa que solicite 5 números. O programa deverá ao final exibir TODOS os números cadastrados no
             * seguinte formato (utilize estrutura de Repetição):
             * 
             * n1 - n2 - n3 - n4 - n5
             * 
             * E também deverá informar qual foi o maior e o menor numero cadastrado.
             * Observe que após o último número não há um “-“
             */

            int[] numeros = new int[5];
            int maior = 0, menor = 0, cont;

            for (cont = 0; cont < 5; cont++)
            {
                Console.Write("Digite um numero: ");
                numeros[cont] = Convert.ToInt16(Console.ReadLine());

                if (cont == 0) //é o primeiro numero digitado
                {
                    maior = numeros[cont];
                    menor = numeros[cont];
                    continue;
                }

                //verifica quem é o maior / menor
                if (numeros[cont] > maior)
                    maior = numeros[cont];

                if (numeros[cont] < menor)
                    menor = numeros[cont];
            }

            //exibição
            for (cont = 0; cont < 4; cont++)
            {
                Console.Write("{0} - ", numeros[cont]);
            }
            Console.Write("{0}\n", numeros[cont]);

            Console.WriteLine("\nO maior numero digitado foi {0}", maior);
            Console.WriteLine("O menor numero digitado foi {0}", menor);

            Console.ReadKey();
        }
    }
}