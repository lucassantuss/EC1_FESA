using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_ContaLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            19.	Conta Letras
            Faça um programa que solicite uma frase e uma letra. 
            Então, seu programa deverá exibir a quantidade de 
            vezes que a letra aparece na frase.

            Ex:
            Digite uma frase:  “Olá mundo cruel”
            Digite uma letra:  “l”
  
            A letra [l]  aparece 2 vezes na frase.
            */

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite um caractere: ");
            char letra = Console.ReadLine()[0];

            // Utilizando For
            int total = 0;

            for (int c = 0; c < frase.Length; c++)
            {
                if (frase[c] == letra)
                    total++;
            }

            Console.WriteLine("A letra [{0}] aparece {1} vezes na frase.",
                letra, total);

            Console.ReadLine();

            // Utilizando While
            int quantidade = 0;
            int n = 0;
            while (n < frase.Length)
            {
                if (frase[n] == letra)
                    quantidade++;

                n++;
            }

            Console.WriteLine("A letra {0} aparece {1} vezes na frase", letra, quantidade);

            Console.ReadLine();
        }
    }
}