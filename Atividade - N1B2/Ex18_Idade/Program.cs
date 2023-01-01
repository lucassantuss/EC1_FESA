using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 18
             * 
             * Leia a idade de 20 pessoas e exiba a soma das idades,
             * a média das idades e quantas pessoas são maiores de idade. 
             */

            // Declaração de Variáveis
            float soma = 0, media = 0;
            int idade, ii = 0;

            // Laço de repetição para solicitar idade até completar as 20 pessoas
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + " - Digite sua idade : ");
                idade = int.Parse(Console.ReadLine());

                // Cálculo da soma das idades
                soma += idade;

                // Pessoas +18
                if (idade >= 18)
                    ii++;
            }

            // Cálculo da média das idades
            media = soma / 20;

            // Exibição dos resultados
            Console.WriteLine("\n A soma das idades é : " + soma);
            Console.WriteLine("\n A média das idades é : " + media);
            Console.WriteLine($"\n O número de pessoas maior de idade é: {ii}");

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}