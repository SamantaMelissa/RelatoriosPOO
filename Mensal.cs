using System;

namespace Alua10Sobreposicao
{
    public class Mensal : Relatorio
    {
         public override void mostrarRelatorio(){

            base.mostrarRelatorio();
            
            Console.WriteLine("Mostrando relatório por mês.");

         }

    }
}