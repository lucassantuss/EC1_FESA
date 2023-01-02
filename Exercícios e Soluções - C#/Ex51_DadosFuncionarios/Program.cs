using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex51_DadosFuncionarios
{
    internal class Program
    {
        struct Funcionario
        {
            public string nome;
            public double salario;
        }

        static void Main(string[] args)
        {
            /*
            51.	Funcionários

            Faça um programa que armazene até 30 funcionarios, guardando o nome  e o salário. 
            Ao final, exiba:
            
            O maior salário, o menor salário, 
            a soma dos salários e a média salárial.
            */

            const int MAX = 30;

            Funcionario[] funcionarios = new Funcionario[30];

            int qtde = 0;
            char resp;

            for (int n = 0; n < MAX; n++)
            {
                qtde++;
                Console.WriteLine("Digite o nome: ");
                funcionarios[n].nome = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                funcionarios[n].salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Deseja sair? <s/n>");
                resp = Console.ReadLine().ToUpper()[0];
                if (resp == 'S')
                    break;
            }

            double maior = funcionarios[0].salario,
                   menor = funcionarios[0].salario,
                   soma = 0;

            for (int n = 0; n < qtde; n++)
            {
                if (funcionarios[n].salario > maior)
                    maior = funcionarios[n].salario;

                if (funcionarios[n].salario < menor)
                    menor = funcionarios[n].salario;

                soma = soma + funcionarios[n].salario;
            }

            Console.WriteLine("\nMaior: {0:F2}\nMenor: {1:F2}\nSoma: {2:F2}\nMédia: {3:F2}",
                maior, menor, soma, soma / qtde);

            Console.ReadKey();
        }
    }
}