using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_SomaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            33.	Soma e Média

            Faça um program que leia N valores e os acumule em uma variável. 
            A cada valor lido, pergunte ao usuário se ele deseja parar ou continuar. 
            Quando ele solicitar parar, exiba um menu com as seguintes opçoes:

            1 - Exibir a soma dos valores lidos
            2 - Exibir a média dos valores lidos
            3 - Sair
            */

            int soma = 0;
            int qtde = 0;
            int numero;

            do
            {
                Console.WriteLine("Digite um numero inteiro para acumular ou -1 para sair: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero != -1)
                {
                    soma += numero; // soma = soma + numero
                    qtde++;
                }
            }
            while (numero != -1);

            do
            {
                Console.WriteLine("Digite uma opção: \n(1) soma \n(2) média \n(3) sair:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 1)
                    Console.WriteLine("Soma: {0}", soma);
                else if (numero == 2)
                    Console.WriteLine("Média: {0}", Convert.ToDouble(soma) / qtde); // conversão para forçar resultado fracionado
            }
            while (numero != 3);
        }
    }
}