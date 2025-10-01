using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesExemplos
{
    public class testeFibonacci
    {
        [TestMethod]
        public void testFibonacci()
        {
            int posicao = 6;
            int valorEsperado = 8;
            int valorObtido;
            Fibonacci fibonacci = new Fibonacci();

            valorObtido = fibonacci.valorNaPosicao(posicao);

            Assert.AreEqual(valorEsperado, valorObtido);
        }
    }
}
