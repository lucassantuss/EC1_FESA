using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3, n4, mediap;

            Console.WriteLine("NOTAS DA DISCIPLINA DE MATEMÁTICA");

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            mediap = (n1 * 1 + n2 * 2 + n3 * 3 + n4 * 4) / 10;

            Console.WriteLine("\nPrimeira nota: " + n1);
            Console.WriteLine("Segunda nota: " + n2);
            Console.WriteLine("Terceira nota: " + n3);
            Console.WriteLine("Quarta nota: " + n4);
            Console.WriteLine("Média do aluno: " + mediap);
            Console.ReadKey();
        }
    }
}