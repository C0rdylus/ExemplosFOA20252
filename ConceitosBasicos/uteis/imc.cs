using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class imc
    {
        public float CalculaImc(float peso, float altura)
        {
            return peso / (altura * altura);
        }
    }
}
