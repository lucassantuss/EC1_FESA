using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_DadosAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 1
             * 
             * Faça um programa que leia as seguintes informações:
             * 
             * Nome de um aluno
             * Endereço
             * Telefone
             * 
             * Depois de ler essas informações, exiba todas novamente em vídeo
             */

            string nome, endereco;
            int telefone;

            Console.Write("Digite o nome de um aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            telefone = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNome do aluno: " + nome);
            Console.WriteLine("\nEndereço: " + endereco);
            Console.WriteLine("\nTelefone: " + telefone);

            Console.ReadKey();
        }
    }
}