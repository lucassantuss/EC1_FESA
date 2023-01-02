using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Renda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10.	Renda

            Solicite: nome, salário, sexo(M/F) e exiba ao final:

            Olá sr(a) nome, seu salário é ____
            Seu sexo é:
            (se for 'M' ou 'm' exibir "masculino",  se for 'F' ou 'f' exibir "feminino")
            (Se salario = 0  exibir "falido"
                  salario entre 1 e 15000 "marajá"
                  salario > 15000 "Corintiano"
            */

            string nome;
            char sexo;
            double salario;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo: [F]eminino e [M]asculino: ");
            sexo = Console.ReadLine()[0];

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Olá sr(a) {0}, seu salário é R$ {1:F2}", nome, salario);

            Console.Write("Seu sexo é: ");
            if (sexo == 'm' || sexo == 'M')
                Console.WriteLine("Masculino");
            else if (sexo == 'f' || sexo == 'F')
                Console.WriteLine("Feminino");
            else
                Console.WriteLine("Indefinido!");

            if (salario <= 0)
                Console.WriteLine("Falido");
            else if (salario <= 15000)
                Console.WriteLine("Marajá");
            else
                Console.WriteLine("Vai corinthians!!!");

            Console.ReadKey();
        }
    }
}