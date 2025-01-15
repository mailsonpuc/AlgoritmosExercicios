using Xunit;
using app.Models;

namespace appTEST;

public class CalculadoraTest
{
    //vem de app.Models
    private ex095 _calc;

    //construto
    public CalculadoraTest()
    {
        _calc = new ex095();
    }

    [Fact]
    public void DeveSoma5com5Retorna10()
    {
        //Arrange
        int n1 = 5, n2 = 5;
        //Act
        int result = _calc.Soma(n1, n2);
        //Assert
        Assert.Equal(10, result);

    }
}
