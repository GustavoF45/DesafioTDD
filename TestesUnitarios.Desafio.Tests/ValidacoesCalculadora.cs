using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesCalculadora
    {
        [Fact]
        public void Somar_DoisNumeros_RetornaSoma()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Subtrair_DoisNumeros_RetornaDiferenca()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Subtrair(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DoisNumeros_RetornaProduto()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Multiplicar(2, 3);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Dividir_DoisNumeros_RetornaQuociente()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DivisaoPorZero_LancaExcecao()
        {
            var calculadora = new Calculadora();
            Assert.Throws<System.DivideByZeroException>(() => calculadora.Dividir(6, 0));
        }
    }
}