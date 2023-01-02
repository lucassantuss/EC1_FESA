using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 18. FATORIAL
             * 
             * Faça um programa que solicite um número e exiba o 
             * fatorial deste número.
             * 
             * ex.
             * 
             * 5! = 5*4*3*2*1  = 120
             */

            // Utilizando For
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;

            if (numero == 0)
                fatorial = 1;
            else
            {
                for (int n = 1; n <= numero; n++)
                {
                    fatorial = fatorial * n;
                }
            }

            Console.WriteLine("{0}! = {1}\n", numero, fatorial);

            // Utilizando do While
            fatorial = 1;
            
            do
            {
                fatorial = fatorial * numero;
                numero--;
            }
            while (numero >= 1);

            Console.WriteLine("O fatorial é {0}", fatorial);
            Console.ReadLine();
        }
    }
}