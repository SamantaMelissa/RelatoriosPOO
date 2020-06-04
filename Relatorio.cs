using System;
namespace Alua10Sobreposicao
{
    public class Relatorio
    {
        public DateTime data { get; set;}
        

        public virtual void mostrarRelatorio(){
            
            Console.WriteLine("Mostrando relatório geral.");
        }


        


        
    }
}