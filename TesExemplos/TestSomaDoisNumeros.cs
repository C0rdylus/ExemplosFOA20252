using ConceitosBasicos.uteis;

namespace TesExemplos
{
    [TestClass]
    public sealed class TestSomaDoisNumeros
    {
        [TestMethod]
        public void TestMethod1()
        {
            //cenario
            int num1 = 20, num2 = 22, result;
            somaDoisNumeros somaDoisNumeros = new somaDoisNumeros();

            //açao
            result = somaDoisNumeros.somar(num1, num2);

            //verificaçao
            Assert.AreEqual(42, result);
        }
    }
}
