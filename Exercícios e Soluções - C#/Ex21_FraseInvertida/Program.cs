using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_FraseInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            21. Faça um programa que solicite um texto e então 
            exiba-o invertido:

            ex:
            BOZO
            R: OZOB
            */

            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();

            // Utilizando For
            for (int contador = texto.Length - 1; contador >= 0; contador--)
                Console.Write(texto[contador]);

            Console.ReadLine();

            // Utilizando While
            int n = texto.Length - 1;
            
            while (n >= 0)
            {
                Console.Write(texto[n]);
                n--;
            }

            Console.ReadLine();
        }
    }
}