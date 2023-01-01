using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_OrdemDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 16
             * 
             * Dados três valores A, B e C, construa um algoritmo, que imprima os valores de forma decrescente (do maior para o menor). 
             */

            // Declaração de Variáveis
            int a, b, c;

            // Solicita os três valores
            Console.WriteLine("Digite três valores: \n");

            Console.Write("Digite o 1º valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3º valor: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("\n---ORDEM DECRESCENTE---\n");

            // Verifica se a é maior que b
            if (a > b)
            {
                // Verifica se b é maior que c, logo: (a > b > c)
                if (b > c)
                    Console.WriteLine(a + " - " + b + " - " + c);

                // Verifica se a é maior que c, logo: (a > c > b)
                else if (a > c)
                    Console.WriteLine(a + " - " + c + " - " + b);

                // Caso contrário, c é maior que a e b, logo: (c > a > b)
                else
                    Console.WriteLine(c + " - " + a + " - " + b);
            }

            // Verifica se b é maior que c
            else if (b > c)
            {
                // Verifica se a é maior que c, logo: (b > a > c)
                if (a > c)
                    Console.WriteLine(b + " - " + a + " - " + c);

                // Caso contrário, a é menor que b e c, logo: (b > c > a)
                else
                    Console.WriteLine(b + " - " + c + " - " + a);
            }

            // Caso contrário, c é maior que b e a, logo: (c > b > a)
            else
                Console.WriteLine(c + " - " + b + " - " + a);

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}