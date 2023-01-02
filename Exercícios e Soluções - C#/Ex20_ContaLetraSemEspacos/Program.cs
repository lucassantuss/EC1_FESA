using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_ContaLetraSemEspacos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 20 - ContaLetraSemEspacos

            O comando Length das variáveis do tipo string conta 
            todas as letras de uma String, inclusive os espaços.

            Faça um programa que conte as letras de uma string, 
            ignorando os espaços. Exiba no vídeo o total de letras. 
            Não use o replace!
            */

            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Utilizando For
            int total = 0;
            int contador;

            for (contador = 0; contador < frase.Length; contador++)
            {
                if (frase[contador] != ' ')
                    total++;
            }
            Console.WriteLine("{0}", total);

            Console.ReadLine();

            // Utilizando While
            int n = 0;
            contador = 0;

            while (n < frase.Length)
            {
                if (frase[n] != ' ')
                    contador++;

                n++;
            }

            Console.WriteLine("O total de letras é {0}", contador);
            Console.ReadLine();
        }
    }
}