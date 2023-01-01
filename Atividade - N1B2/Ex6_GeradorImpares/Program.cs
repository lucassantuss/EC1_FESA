using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_GeradorImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 6
             * 
             * Escreva um algoritmo que gera e escreva os números ímpares entre 100 e 200. 
             */

            Console.WriteLine("Números ímpares entre 100 e 200:\n");

            // Laço de repetição de 100 até 200
            for (int i = 100; i <= 200; i++)
            {
                // Verifica se a variável i é impar, ou seja, se o resto da divisão dela por 2 é diferente de zero
                if (i % 2 != 0)
                {
                    // Exibe o número impar
                    Console.WriteLine(i);
                }
            }

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}