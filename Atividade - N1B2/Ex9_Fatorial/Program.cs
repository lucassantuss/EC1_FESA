using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 9
             * 
             * Escreva um algoritmo que leia um valor inicial A e imprima a sequência de cálculo de A! e o resultado.
             * 
             * Ex:
             * 
             * 5! = 5 X 4 X 3 X 2 X 1 = 120 
             */

            // Declaração de variáveis
            ulong numero, fatorial;

            Console.WriteLine("--- FATORIAL ---\n");

            // Solicita um número
            Console.Write("Digite um número: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            fatorial = 1;

            // Exibe o número digitado pelo usuário
            Console.Write("\n{0}! = {1} ", numero, numero);

            // Laço de repetição do valor do número digitado até 1
            for (ulong n = numero; n >= 1; n--)
            {
                // Cálculo do fatorial
                fatorial = fatorial * Convert.ToUInt64(n);

                // if pra não exibir o número digitado pelo usuário denovo
                if (n != numero)
                {
                    // Exibe o valor de n (número da sequência do cálculo)
                    Console.Write("X {0} ", n);
                }
            }

            // Exibe o valor do fatorial
            Console.Write("= {0}", fatorial);

            // Comando para esperar o usuário usar uma tecla
            Console.ReadLine();
        }
    }
}