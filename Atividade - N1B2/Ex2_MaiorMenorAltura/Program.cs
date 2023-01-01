using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_MaiorMenorAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos ver quem é o mais alto e quem é o mais baixinho?");

            double altura = 0, maior = 0, menor = 0;
            int i = 0;

            Console.WriteLine("\nDigite a altura de cada pessoa:");

            //Solicitando a primeira altura como base para o laço
            Console.Write("1ª altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            menor = altura;
            maior = altura;

            //Laço de repetição de 2 até 15 (porque o primeiro valor já foi digitado)
            for (i = 2; i <= 15; i++)
            {
                //Solicitando as próximas alturas 
                Console.Write("" + i + "ª altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                //Condição para ser o menor 
                if (altura < menor)
                    menor = altura;

                //Condição para ser o maior
                if (altura > maior)
                    maior = altura;
            }

            //Imprimindo resultado na tela do usuário
            Console.WriteLine($"\nA menor altura é {menor:0.00}m.");
            Console.WriteLine($"\nA maior altura é {maior:0.00}m.");
            Console.ReadKey();
        }
    }
}