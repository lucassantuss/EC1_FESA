using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Vogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            24.	Vogais
            Faça um programa que solicite um texto qualquer, 
            e então seu programa deverá exibir em vídeo apenas as vogais 
            do texto.
            */

            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();

            // Utilizando For
            for (int n = 0; n < texto.Length; n++)
            {
                if (texto[n] == 'a' || texto[n] == 'e' ||
                    texto[n] == 'i' || texto[n] == 'o' ||
                    texto[n] == 'u' || texto[n] == 'A' ||
                    texto[n] == 'E' || texto[n] == 'I' ||
                    texto[n] == 'O' || texto[n] == 'U')
                    
                    Console.Write(texto[n]);
            }

            Console.ReadLine();

            // Utilizando While
            int contador = 0;

            while (contador < texto.Length)
            {
                char letra = texto.ToUpper()[contador];
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' ||
                    letra == 'U')
                    Console.Write(texto[contador]);

                contador++;
            }

            Console.ReadLine();
        }
    }
}