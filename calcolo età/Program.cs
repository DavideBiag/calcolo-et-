using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolo_età
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Console.WriteLine("Inserisci la data di nascita:  ");
            p.dataNascita= DateTime.Parse(Console.ReadLine());

            Console.WriteLine( "hai {0} anni", p.CalcoloEtà());
            Console.ReadLine(); 
        }
    }
}
