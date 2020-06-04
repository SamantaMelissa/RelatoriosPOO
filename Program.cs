using System;

namespace Alua10Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data:");

            Mensal relatorioMensal = new Mensal();
            relatorioMensal.mostrarRelatorio();

            Console.WriteLine("Data:");

            Anual relatorioAnual = new Anual();
            relatorioAnual.mostrarRelatorio();


        }
    }
}
