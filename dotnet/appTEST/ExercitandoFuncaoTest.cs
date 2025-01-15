using Xunit;
using app.Models;

namespace appTEST;

public class ExercitandoFuncaoTest
{
    //vem de app.Models
    private ex105 _calTaxa;

    //construto
    public ExercitandoFuncaoTest()
    {
        _calTaxa = new ex105();
    }

    [Fact]
    public void DeveFazeroAUmentoDe10PorcentoDe1500()
    {
        //Arrange
        double preco = 1500;
        double taxa = 10;
        //Act
        double result = _calTaxa.aumenta(preco, taxa);

        //Assert
        Assert.Equal(1650, result);

    }




    [Fact]
    public void DeveFazeroAmetadeDe1500()
    {
        //Arrange
        double preco = 1500;

        //Act
        double result = _calTaxa.metade(preco);

        //Assert
        Assert.Equal(750, result);

    }



    [Fact]
    public void DeveFazeroDobroDe1500()
    {
        //Arrange
        double preco = 1500;

        //Act
        double result = _calTaxa.dobro(preco);

        //Assert
        Assert.Equal(3000, result);

    }



    [Fact]
    public void DeveFazer5PorcentoDeReducaoDe1500()
    {
        //Arrange
        double preco = 1500;
        double taxa = 5;
        //Act
        double result = _calTaxa.diminuir(preco, taxa);

        //Assert
        Assert.Equal(1425, result);

    }


}
