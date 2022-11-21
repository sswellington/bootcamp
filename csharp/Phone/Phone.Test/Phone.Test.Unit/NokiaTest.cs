using FluentAssertions;
using Phone.Core.Class;
using Phone.Core.Models;
using Phone.Test.Unit.Model;
using Xunit;

namespace Phone.Test.Unit;

public class NokiaTest
{
    [Fact(DisplayName="Instalar Aplicativo")]
    public void InstalarAplicativo_OK_SucessoMsg()
    {
        //Arrange
        var model = new SmartphoneModelTest();
        var nokia = new Nokia(model.Phone);
        const string app = InstalarAplicativoTest.Input;
        var isEqual = InstalarAplicativoTest.Output;
        
        //Act 
        var result = nokia.InstalarAplicativo(app);

        //Assert
        result.Should().Be(isEqual);
    }
    
    [Fact(DisplayName = "Instalar Aplicativo")]
    public void ConstrutorFull_InstalarAplicativo_OK_SucessoMsg()
    {
        //Arrange
        var model = new SmartphoneModelTest().Phone;
        var phone = new Nokia(model.Numero, model.Modelo,model.Imei, model.Memoria);
        const string app = InstalarAplicativoTest.Input;
        var isEqual = InstalarAplicativoTest.Output;

        //Act 
        var result = phone.InstalarAplicativo(app);

        //Assert
        result.Should().Be(isEqual);
    }
}