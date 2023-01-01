using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            double peso, altura, imc;

            // entrada de dados
            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            // cálculo do IMC
            imc = (peso / Math.Pow(altura, 2));

            if (imc < 20)
                Console.WriteLine("\nVocê está abaixo do peso. ");
            else if (imc < 25)
                Console.WriteLine("\nVocê está no peso normal. ");
            else if (imc < 30)
                Console.WriteLine("\nVocê está acima do peso. ");
            else if (imc < 40)
                Console.WriteLine("\nVocê está obeso. ");
            else if (imc >= 40)
                Console.WriteLine("\nVocê está com obesidade mórbida. ");

            Console.ReadKey();
        }
    }
}