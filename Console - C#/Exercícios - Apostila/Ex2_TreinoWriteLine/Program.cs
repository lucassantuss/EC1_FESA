using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_TreinoWriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 2
             *
             * Treinamento de WriteLine
             * 
             * Solicite os seguintes dados: nome, sobrenome, rua, nº, bairro, cidade, estado e cep.
             * 
             * Exiba:
             * 
             * Sr: Nome + Sobrenome + Residente à Rua, nº, bairro, cidade - estado, CEP. Favor comparecer à escola neste sábado. 
             */

            string nome, sobrenome, rua, bairro, cidade, estado, cep;
            int numero;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nDigite o sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine("\nDigite a rua: ");
            rua = Console.ReadLine();

            Console.WriteLine("\nDigite o número da casa: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o bairro: ");
            bairro = Console.ReadLine();

            Console.WriteLine("\nDigite a cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\nDigite o estado: ");
            estado = Console.ReadLine();

            Console.WriteLine("\nDigite o CEP: ");
            cep = Console.ReadLine();

            Console.WriteLine($"\nSr: {nome} {sobrenome} residente à {rua}, {numero}, {bairro}, {cidade} - {estado}, {cep}. Favor comparecer à escola neste sábado.");

            Console.ReadKey();
        }
    }
}