using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TesExemplos
{
    [TestClass]
    public class testImc
    {
        [TestMethod]
        public void TestCalculaImc()
        {
            //cenario
            float peso = 80;
            float altura = 1.79f;
            float imcCalculado;
            imc imc = new imc();

            //açao
            imcCalculado = imc.CalculaImc(peso, altura);

            //verificaçao
            Assert.AreEqual(Math.Round(24.97, 2), Math.Round(imcCalculado, 2));
        }
    }
}
