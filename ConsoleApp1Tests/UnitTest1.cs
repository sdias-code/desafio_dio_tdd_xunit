using ConsoleApp1;

namespace ConsoleApp1Tests
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            DateTime data = DateTime.Now;
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestarSoma(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();            
         
            int resultadoCalculadora = calc.somar(n1, n2);
                       
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(9, 4, 5)]
        public void TestarSubtracao(int n1, int n2, int result)
        {
            Calculadora calc = construirClasse();

            int resultCalc = calc.subtrair(n1, n2);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestarMultiplicacao(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.multiplicar(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        public void TestarDivisao(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.dividir(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.multiplicar(3, 3);
            calc.somar(7, 8);
            calc.subtrair(17, 8);
            calc.dividir(10, 2);
            calc.multiplicar(5, 3);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}