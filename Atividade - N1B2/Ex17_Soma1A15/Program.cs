using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_Soma1A15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 17
             * 
             * Escreva um algoritmo que calcule a soma dos números de 1 a 15. 
             */

            // Declaração de Variáveis
            int cont, soma = 0;

            Console.WriteLine("Cálculo da soma dos números de 1 a 15");

            // Laço de repetição de 1 até 15
            for (cont = 1; cont <= 15; cont++)
            {
                // Soma o valor de cont com o valor das somas anteriores
                soma = soma + cont;
            }

            // Exibe o valor da soma dos números de 1 a 15
            Console.WriteLine("\nO resultado da soma dos números de 1 a 15 é: {0}", soma);

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}