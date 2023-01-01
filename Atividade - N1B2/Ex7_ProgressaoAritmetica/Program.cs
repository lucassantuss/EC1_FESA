using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_ProgressaoAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 7
             * 
             * Escreva um algoritmo que leia um valor inicial A e uma razão R e imprima uma sequência em PA, contendo 10 elementos
             */

            // Declaração de variáveis
            float valor, valorinicial, razao;

            Console.WriteLine("--- SEQUÊNCIA EM PA ---\n");

            // Solicita o valor inicial
            Console.Write("Digite o valor inicial: ");
            valorinicial = float.Parse(Console.ReadLine());

            // Solicita a razão
            Console.Write("Digite a razão: ");
            razao = float.Parse(Console.ReadLine());

            Console.WriteLine("\nA sequência em Progressão Aritmética ficou assim: \n");

            // Laço de repetição de 1 até 10
            for (int i = 1; i <= 10; i++)
            {
                // Fórmula da PA
                valor = valorinicial + (i - 1) * razao;

                // Exibe o valor
                Console.Write("| " + valor + " |");
            }

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}