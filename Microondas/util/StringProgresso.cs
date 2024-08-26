using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.util
{
    public static class StringProgresso
    {   
        public static string stringProgresso (int potencia, string simbolo)
        {
            string progresso = "";
            string progressoFinal = "";

            if (potencia == 1)
            {
                progresso = ". ";
            }
            else if (potencia == 2)
            {
                progresso = ".. ";
            }
            else if (potencia == 3)
            {
                progresso = "... ";
            }
            else if (potencia == 4)
            {
                progresso = ".... ";
            }
            else if (potencia == 5)
            {
                progresso = "..... ";
            }
            else if (potencia == 6)
            {
                progresso = "...... ";
            }
            else if (potencia == 7)
            {
                progresso = "....... ";
            }
            else if (potencia == 8)
            {
                progresso = "........ ";
            }
            else if (potencia == 9)
            {
                progresso = "......... ";
            }
            else if (potencia == 10)
            {
                progresso = ".......... ";
            }

            if (simbolo != "") 
            {
                progressoFinal = progresso.Replace('.', simbolo[0]);
            }

            return progressoFinal;
        }
    }
}
