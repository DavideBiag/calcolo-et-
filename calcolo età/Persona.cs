using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolo_età
{
    internal class Persona
    {
        public DateTime dataNascita { get; set; }

        public int CalcoloEtà()
        {
            int anni= DateTime.Now.Year-dataNascita.Year;
           
            if(DateTime.Now.Month<dataNascita.Month || DateTime.Now.Month == dataNascita.Month && DateTime.Now.Day < dataNascita.Day)
            {
                anni = anni - 1;
                return anni;
            }
            else
            {
                return anni;
            }

        }
    }
}
