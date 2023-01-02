using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_SomaParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            7-) (Até 2,0 pontos) Faça um programa em C# que 
            some todos os números pares e todos os 
            números impares em um intervalo de números escolhido 
            pelo usuário:
            
            Ex: Caso o usuário escolha o intervalo 
            de 1 a 10, o programa deve exibir: 
            Soma dos pares: 30 , Soma dos impares: 25.
            */

            int inicio, fim;
            int somaPar = 0, somaImpar = 0;

            Console.WriteLine("Digite o intervalo inicial: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o intervalo final: ");
            fim = Convert.ToInt32(Console.ReadLine());

            if (inicio > fim)
                Console.WriteLine("\nInício não pode ser maior que o fim.");
            else
            {
                for (int n = inicio; n <= fim; n++)
                {
                    if (n % 2 == 0)
                        somaPar = somaPar + n;
                    else
                        somaImpar = somaImpar + n;
                }
                Console.WriteLine("\nSoma dos pares: {0} ", somaPar);
                Console.WriteLine("Soma dos impares: {0} ", somaImpar);
            }

            Console.ReadKey();
        }
    }
}