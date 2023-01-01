using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_SomaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Somando todos os números ímpares que são múltiplos de 3, entre 1 e 500");

            //Laço de repetição de 1 a 500
            for (int i = 1; i <= 500; i++)
            {
                //Selecionando os números ímpares
                if (i % 2 != 0)
                {
                    //Selecionando os números múltiplos de 3
                    if (i % 3 == 0)
                    {
                        //Somando estes números 
                        soma = soma + i;
                    }
                }
            }

            //Imprimindo o resultado na tela do usuário
            Console.WriteLine($"\nO resultado é: {soma}.");

            Console.ReadKey();
        }
    }
}