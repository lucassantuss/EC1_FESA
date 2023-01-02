using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex41_MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            41.	MaiorMenor

            Faça um programa que solicite 5 números. 
            O programa deverá ao final exibir TODOS os números cadastrados no seguinte formato (utilize estrutura de  Repetição):
            n1  -  n2  -  n3  -  n4  -   n5
            E também deverá informar qual foi o maior e  
            o menor numero cadastrado.
            */

            int[] numeros = new int[5];

            for (int n = 0; n < numeros.Length; n++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[n] = Convert.ToInt16(Console.ReadLine());
            }

            int maior = numeros[0];
            int menor = numeros[0];
            Console.Write($"\n{numeros[0]}");

            for (int n = 1; n < numeros.Length; n++)
            {
                Console.Write($" - {numeros[n]}");

                if (numeros[n] > maior)
                    maior = numeros[n];

                if (numeros[n] < menor)
                    menor = numeros[n];
            }

            Console.WriteLine("\n\nMaior elemento: {0}", maior);
            Console.WriteLine("Menor elemento: {0}", menor);
            Console.ReadLine();
        }
    }
}