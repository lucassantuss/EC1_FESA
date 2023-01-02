using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex40_MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 40. Solicite 5 números e armazene-os em um vetor. 
             * Depois, exiba em vídeo qual foi o maior número lido.              
             */

            int[] numeros = new int[5];

            for (int n = 0; n < numeros.Length; n++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[n] = Convert.ToInt32(Console.ReadLine());
            }

            int maior = numeros[0];

            for (int n = 0; n < numeros.Length; n++)
            {
                if (numeros[n] > maior)
                    maior = numeros[n];
            }

            Console.WriteLine("\nMaior: {0}", maior);
            Console.ReadKey();
        }
    }
}