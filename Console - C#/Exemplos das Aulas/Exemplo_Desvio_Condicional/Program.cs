using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Desvio_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * dar um aumento ao salario de 15% para quem ganha menos que 1000,
             * e 10% para o restante
             */

            float salario, aumento;

            Console.Write("Digite seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario < 1000)
            {
                //bloco de codigo executado se condição for verdadeira
                aumento = salario * 0.15f;
            }
            else
            {
                //bloco de codigo executado se condição for falsa
                aumento = salario * 0.10f;
            }

            Console.WriteLine($"Salario Atual R$ {salario:0.00}");
            Console.WriteLine($"Aumento R$ {aumento:0.00}");
            Console.WriteLine($"Salario com Aumento R$ {salario + aumento:0.00}");
            Console.WriteLine();

            //-----------------------------------------------------
            int numero;

            Console.Write("Digite um numero qualquer: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) // % resto da divisão
                Console.WriteLine("O numero digitado é par!!!");

            Console.WriteLine();

            //-----------------------------------------------------
            Int16 a, b;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            if (a > b)
                Console.WriteLine("A é maior que B");
            else if (b > a)
                Console.WriteLine("B é maior que A");
            else
                Console.WriteLine("A é igual a B");

            //outra maneira
            if (a > b)
                Console.WriteLine("A é maior que B");
            else
            {
                if (b > a)
                    Console.WriteLine("B é maior que A");
                else
                    Console.WriteLine("A é igual a B");
            }
            Console.ReadKey();
        }
    }
}