using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex41_Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 41
             * 
             * Palíndromo
             * 
             * Faça um programa que solicite um texto. Seu programa deverá dizer se este texto é um palíndromo ou não.
             * 
             * Um palíndromo é uma palavra ou frase que tenha a propriedade de poder ser lida tanto da direita para a
             * esquerda como da esquerda para a direita. EX: ana, arara, lamina animal, etc... 
             */

            string frase;
            int tamanho, cont;
            bool palindromo = true;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            tamanho = frase.Length;
            cont = 0;

            do
            {
                if (frase[cont] != frase[tamanho - 1 - cont])
                {
                    palindromo = false;
                    break;
                }
                cont++;

            } while (cont <= tamanho / 2);

            if (palindromo == true)
                Console.WriteLine("É Palindromo");
            else
                Console.WriteLine("Não é Palindromo");

            Console.ReadKey();
        }
    }
}