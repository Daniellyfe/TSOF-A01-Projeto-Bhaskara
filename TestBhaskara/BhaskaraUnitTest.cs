using BhaskaraApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBhaskara
{
    [TestClass()]


    public class BhaskaraUnitTest
    {


        [TestMethod]
        [DataRow(1, -3, -54, 9, -6)]
        [DataRow(1, 10, 24, -4, -6)]

        public void Teste_de_Raizes(double a, double b, double c, double raizEsperada1, double raizEsperada2)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var (raiz1, raiz2) = bhaskara.CalcularRaizes();

            // Assert
            Assert.AreEqual(raizEsperada1, raiz1, "O valor da raiz 1 está incorreto.");
            Assert.AreEqual(raizEsperada2, raiz2, "O valor da raiz 2 está incorreto.");
        }

        [TestMethod]
        [DataRow(1, -3, -10, 49)]
        [DataRow(7, 3, 4, -103)]
        [DataRow(1, -6, 10, -4)]

        public void Teste_de_Delta(double a, double b, double c, double DeltaEsperado)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var Del1 = bhaskara.CalcularDelta();

            // Assert
            Assert.AreEqual(DeltaEsperado, Del1, "O valor de Delta está incorreto.");

        }


        [TestMethod]
        [DataRow(1, -3, 2, 2, 2, 1)]
        [DataRow(1, -2, 1, 1, 1, 1)]

        public void Teste_de_Uma_Raiz(double a, double b, double c, double delta, double raizEsperada1, double raizEsperada2)
        {

            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var deltaCalculado = bhaskara.TemRaizesReais();

            // Assert
            Assert.AreEqual(delta, raizEsperada1);
        }

    }
}
