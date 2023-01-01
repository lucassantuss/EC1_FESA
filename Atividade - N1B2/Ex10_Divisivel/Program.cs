using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Divisivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 10
             * 
             * Escreva um algoritmo que leia um número e informe se ele é divisível por 10,
             * por 5 ou por 2 ou se não é divisível por nenhum deles. 
             */

            // Declaração de variáveis
            double numero;

            // Solicita um número
            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero % 10 == 0 || numero % 5 == 0 || numero % 2 == 0)
            {
                // If para verificar se o número é divisível por 10
                if (numero % 10 == 0)
                    Console.WriteLine($"\nO {numero} é divisível por 10");

                // If para verificar se o número é divisível por 5
                if (numero % 5 == 0)
                    Console.WriteLine($"\nO {numero} é divisível por 5");

                // If para verificar se o número é divisível por 2
                if (numero % 2 == 0)
                    Console.WriteLine($"\nO {numero} é divisível por 2");
            }

            // else, caso o número não seja divisível por: 10, 5, 2
            else
                Console.WriteLine($"\nO {numero} não é divisível por: 10, 5, 2");

            // Comando para esperar o usuário usar uma tecla
            Console.ReadLine();
        }
    }
}