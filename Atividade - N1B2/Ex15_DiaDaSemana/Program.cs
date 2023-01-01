using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_DiaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 15
             * 
             * Criar um algoritmo que leia um número inteiro entre 1 e 7 e escreva o dia da semana correspondente.
             * 
             * Caso o usuário digite um número fora desse intervalo,
             * deverá aparecer uma mensagem informando que não existe dia da semana com esse número.
             */

            // Declaração de Variáveis
            int semana;

            // Solicita o dia da semana
            Console.Write("Digite o dia da semana entre (1 a 7): ");
            semana = Convert.ToInt16(Console.ReadLine());

            //If para verificar qual é o dia da semana correspondente
            if (semana == 1)
                Console.Write("\nDomingo");

            else if (semana == 2)
                Console.Write("\nSegunda-feira");

            else if (semana == 3)
                Console.Write("\nTerça-feira");

            else if (semana == 4)
                Console.Write("\nQuarta-feira");

            else if (semana == 5)
                Console.Write("\nQuinta-feira");

            else if (semana == 6)
                Console.Write("\nSexta-feira");

            else if (semana == 7)
                Console.Write("\nSábado");

            else
                Console.Write("\nNão existe dia da semana com esse número");

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}