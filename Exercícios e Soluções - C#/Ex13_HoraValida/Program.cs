using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_HoraValida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Hora válida
            // Solicite uma hora no formato HH:MM (formato 24 horas) e informe se a hora é válida ou não.

            Console.WriteLine("Digite a hora no formato hh:mm");
            string horaCompleta = Console.ReadLine();

            int hora = Convert.ToInt32(horaCompleta.Substring(0, 2));
            int minuto = Convert.ToInt32(horaCompleta.Substring(3, 2));

            if (hora >= 0 && hora <= 23 && minuto >= 0 && minuto <= 59)
                Console.WriteLine("Valida!");
            else
                Console.WriteLine("Inválida!");

            Console.ReadKey();
        }
    }
}