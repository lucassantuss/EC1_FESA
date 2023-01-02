using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex46_Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            46. Loteria

            Crie um programa para gerar os 6 números da loteria (1 a 60).
            Cuidado para não gerar números repetidos!
            Ao final, exiba os números gerados.
            */

            int[] numeros = new int[6];
            
            //Array.Resize(ref numeros, 10);
            
            Random gerador = new Random();

            for (int n = 0; n<=5; n++)
            {
                bool existe;
                do
                {
                    existe = false;
                    numeros[n] = gerador.Next(1, 60); // vai gerar de 1 a 60                
                    Console.WriteLine("Sorteado: {0} ", numeros[n]);

                    //procura se o numero gerado já existe no vetor numeros
                    for (int p=0; p<n; p++)
                    {
                        if (numeros[p] == numeros[n])
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                while (existe);
            }

            Console.WriteLine("\nNúmeros da Loteria");

            for (int n = 0; n <= 5; n++)
            {
                Console.WriteLine(numeros[n]); 
            }

            Console.ReadLine();
        }
    }
}