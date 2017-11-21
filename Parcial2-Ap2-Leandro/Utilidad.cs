using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Ap2_Leandro
{
    public class Utilidad
    {
        public static int TOINT(string letra)
        {
            int numero = 0;
            int.TryParse(letra, out numero);
            return numero;
        }
    }
}