using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double n2;
            Double soma;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            soma = n1 + n2;

            Console.Write("A soma dos números digitados é {0}", soma);
            Console.ReadKey();
        }
    }
}