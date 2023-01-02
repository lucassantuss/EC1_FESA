using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_DadosFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 11
             * 
             * Faça um programa que solicite seu nome completo, o 
             * CPF , a  idade e o salário.
             * 
             * Após ler todos os valores, exiba:
             * 
             * A idade.
             * O primeiro nome do nome digitado.
             * As últimas 3 letras do nome digitado.
             * 
             * Calcule e exiba o desconto de INSS  (11%)
             * Exiba o salário final já descontado o INSS
             * Exibir o CPF sem os pontos e sem traço.
             */

            string nome, cpf;
            double salario;
            int idade;

            Console.Write("digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("digite o seu cpf: ");
            cpf = Console.ReadLine();

            Console.Write("digite o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sua idade é {0}", idade);

            int posicaoespaco = nome.IndexOf(' ');
            if (posicaoespaco == -1)
                Console.WriteLine("Primeiro nome: " + nome);
            else
                Console.WriteLine("Primeiro nome: {0}",
                    nome.Substring(0, posicaoespaco));

            Console.WriteLine("INSS {0:F2} ", salario * 0.11);

            Console.WriteLine("CPF: " + cpf.Replace(".", "").Replace("-", ""));

            Console.ReadKey();
        }
    }
}