using System;

namespace Alua10Sobreposicao
{
    public class Anual : Relatorio
    {
        public override void mostrarRelatorio(){

            base.mostrarRelatorio();

            Console.WriteLine("Mostrando relatório por ano.");

        }


    }
}