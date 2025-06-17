using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Test.Accounts.ValueObjects;

public class NameTest
{
    private readonly Name _name = Name.Create("John", "Doe");
    
    [Fact]
    public void ShouldOverrideToStringMethod()
    {
        Assert.Equal("John Doe", _name.ToString());
    }
    
    [Fact]
    public void ShouldImplicitlyConvertToStringMethod()
    {
        string data = _name;
        
        Assert.Equal("John Doe", data.ToString());
    }

    [Fact]
    public void ShouldFailIfFirstNameIsNotValid()
    {
        Assert.Throws<InvalidFirstNameLengthException>(() => Name.Create("a", "Doe"));
    }

    [Fact]
    public void ShouldFailIfSecondNameIsNotValid()
    {
        Assert.Throws<InvalidLastNameLengthException>(() => Name.Create("John", "D"));
    }
}