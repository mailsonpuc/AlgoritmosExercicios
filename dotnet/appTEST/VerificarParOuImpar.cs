
using Xunit;
using app.Models;

namespace appTEST;

public class VerificarParOuImpar
{
    //vem de app.Models
    private ex103 _par;

    //construto
    public VerificarParOuImpar()
    {
        _par = new ex103();
    }

    [Fact]
    public void DeveVerificarSe10ePar()
    {
        //Arrange
        int n1 = 10;
        //Act
        object result = _par.ParOuImpar(n1);
        //Assert
        Assert.Equal("O Número 10 é PAR", result);
    }


    [Fact]
    public void DeveVerificar_Se_ADataATualEimpa()
    {
        //Arrange
        int data = DateTime.Now.Year;
        //Act
        object result = _par.ParOuImpar(data);
        //Assert
        Assert.Equal("O Número 2025 é IMPAR", result);
    }


}
