using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que solicite dois números e apresente a soma e a média desses números

            //Variáveis Gerais
            int n1, n2, soma;
            float media;

            //Entrada de Dados
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Cálculos
            soma = n1 + n2;
            media = soma / 2.0f;

            //Exibir na tela
            Console.WriteLine($"\nA soma é: {soma}");
            Console.WriteLine($"A média é: {media}");

            //Espera por uma tecla
            Console.ReadKey();
        }
    }
}