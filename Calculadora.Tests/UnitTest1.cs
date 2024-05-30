using Xunit;
using Calculadora.Models;

namespace Calculadora.Tests;

public class UnitTest1
{
    public MinhaCalculadora construirClasse()
    {   
        string data = "14/25/2010";
        MinhaCalculadora calculadora = new MinhaCalculadora();
        return calculadora;
    }
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSoma(int v1,int v2,int res)
    {
        MinhaCalculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.somar(v1, v2);

        Assert.Equal(res, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2,1,1)]
    [InlineData(7,3,4)]
    public void TesteSubtracao(int v1,int v2,int res)
    {
        MinhaCalculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.subtrair(v1, v2);

        Assert.Equal(res, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2,4,8)]
    [InlineData(6,3,18)]
    public void TesteMultiplicacao(int v1,int v2,int res)
    {
        MinhaCalculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.multiplicar(v1, v2);

        Assert.Equal(res, resultadoCalculadora);
    }

    [Theory]
    [InlineData(8,2,4)]
    [InlineData(9,3,3)]
    public void TesteDivisao(int v1,int v2,int res)
    {
        MinhaCalculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.dividir(v1, v2);

        Assert.Equal(res, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Given
        MinhaCalculadora calculadora = construirClasse();
        // When
        Assert.Throws<DivideByZeroException>(
            () => calculadora.dividir(3,0)
        );
        // Then
    }

    [Fact]
    public void TestarHistorico()
    {
        // Given
        MinhaCalculadora calculadora = construirClasse();
        calculadora.somar(1,2);
        calculadora.subtrair(1,2);
        calculadora.multiplicar(1,2);
        calculadora.dividir(2,1);
        // When
        var lista = calculadora.historico();
        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);
    }
}