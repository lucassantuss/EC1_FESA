using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_PreencheTela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            23. Faça um programa para preencher a sua tela 
            com 1 caractere escolhido pelo usuário.               
            */

            Console.Write("Digite um caractere para preencher a tela: ");
            char caractere = Console.ReadLine()[0];

            for (int linha = 1; linha <= 24; linha++)
            {
                for (int coluna = 1; coluna <= 78; coluna++)
                {
                    Console.Write(caractere);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}