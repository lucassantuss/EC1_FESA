using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_MRU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            9.	MRU  - movimento retilíneo uniforme. Calcula o tempo e o local de encontro de 2 móveis (C# e fluxograma)

            Formula:
            t = dab / (va - vb)

            Onde: 
            t = tempo
            dab = distância entre o móvel a e  o móvel b
            va = velocidade do movel a
            vb = velocidade do movel b

            local = va * t
	            Onde: 
            local =  local (KM) do encontro

            Exibir ao final:

            Se os móveis se encontrarão ou não, e em caso de se encontrarem,  em que tempo (t) e em que local
            obs: se va <= vb os  móveis nunca se encontrarão!
            */

            double t, dab, va, vb, local;

            Console.WriteLine("Digite a velocidade do móvel a: ");
            va = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a velocidade do móvel b: ");
            vb = Convert.ToDouble(Console.ReadLine());

            if (va <= vb)
                Console.WriteLine("Eles nunca irão se encontrar!");
            else
            {
                Console.WriteLine("Digite a distância entre eles: ");
                dab = Convert.ToDouble(Console.ReadLine());

                t = dab / (va - vb);
                local = va * t;

                Console.WriteLine("os móveis irão se encontrar no km {0}" +
                    " depois de {1} horas", local, t);
            }

            Console.ReadKey();
        }
    }
}