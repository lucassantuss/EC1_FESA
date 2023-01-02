using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            9-) (até 2,0 ptos) Triângulo é uma forma geométrica composta por três lados (ex. A,B,C) ,
            sendo que cada lado é menor que a soma dos outros dois lados. Sendo assim, a regra para
            considerarmos uma forma geométrica como um triângulo é:  A<B+C e B<A+C e C<A+B.

            Há 3 tipos de triângulos: 
             •	Isósceles quando possui dois lados iguais e um diferente, sendo A=B ou A=C ou B=C; 
             •	Escaleno quando possui todos os lados diferentes, sendo A != B e B!= C e  A != C; 
             •	Equilátero, que possui todos os lados iguais, sendo A=B e B=C e A=C.

            Faça um algoritmo (C# ou FLUXOGRAMA) que deverá receber as medidas dos 3 lados de um
            triângulo e então seu programa deverá primeiro dizer se as medidas informadas realmente
            formam um triângulo e na sequência informar o tipo do triângulo.
            */
            
            int a, c, b;

            Console.Write("Digite o lado a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.Write("É um triângulo do tipo : ");
                if (a == b && b == c && a == c)
                    Console.WriteLine("Equilátero");
                else if (a != b && b != c && a != c)
                    Console.WriteLine("Escaleno");
                else
                    Console.WriteLine("Isósceles");
            }
            else
                Console.WriteLine("Não é um triângulo.");

            Console.ReadKey();
        }
    }
}