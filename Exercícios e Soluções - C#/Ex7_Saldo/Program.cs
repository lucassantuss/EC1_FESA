using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Saldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            7. Saldo

            Solicite:
            nome
            salário
            despesas com saúde (ds)
            despesas com lazer  (dl)
            despesas com alimentação  (da)

            saldo = salario - (ds+dl+da)
             
            se saldo <=0 "coitado!"
            se saldo entre 0 e 3000 "guarde para o mês que vem"
            se saldo entre 3001 e 5000 "muito bom! está divorciado?"
            se saldo > 5000  "parabéns corintiano"
            */

            string nome;
            double salario, ds, dl, da;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as despesas com saúde : ");
            ds = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as despesas com lazer : ");
            dl = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as despesas com alimentação : ");
            da = Convert.ToDouble(Console.ReadLine());

            double saldo = salario - (ds + dl + da);

            Console.WriteLine("Seu saldo é : {0}", saldo);
            /*
            se saldo <=0 "coitado!"
            se saldo entre 0 e 3000 "guarde para o mês que vem"
            se saldo entre 3001 e 5000 "muito bom! está divorciado?"
            se saldo > 5000  "parabéns corintiano"
            */

            if (saldo <= 0)
                Console.Write("Coitado!");
            else if (saldo <= 3000)
                Console.Write("Guarde para o mês que vem!");
            else if (saldo <= 5000)
                Console.Write("muito bom! está divorciado?!");
            else
                Console.Write("Parabéns corintiano");

            Console.ReadKey();
        }
    }
}