using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    internal class calcularAumento
    {
        public static decimal Aumento (decimal salario, float aumento)
        {
            return salario * ((decimal)aumento / 100m);
        }
    }
}
