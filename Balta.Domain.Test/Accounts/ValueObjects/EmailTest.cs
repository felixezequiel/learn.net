using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Test.Accounts.ValueObjects;

public class EmailTest
{
    [Theory]
    [InlineData("test@balta.io")]
    [InlineData("test@gmail.com")]
    [InlineData("test@hotmail.com")]
    public void ShouldCreateAnEmail(string address)
    {
        var email = Email.Create(address);
        Assert.Equal(email.Address, address);
    }

    [Fact]
    public void ShouldThrowAnInvalidLengthEmailExceptionForNull()
    {
        Assert.Throws<InvalidEmailLengthException>(() => Email.Create(null!));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public void ShouldThrowAnInvalidLengthEmailException(string address)
    {
        Assert.Throws<InvalidEmailLengthException>(() => Email.Create(address));
    }

    [Theory]
    [InlineData("dkjasbdkjsagdihsakgdhlkasg")]
    [InlineData(
        "sadhfpisdabfiohsadfhsdafpiuahsdfhugasdkjfbsdakjfhasdklhfgbjsadhvfbljsadhvbfsadkhfvbashdfvapsdfsadjhfgasdhfvbiasdvfohsagdjkfhjhfasdgiofgsdaiuyfgisdagfiu@gmail.com")]
    public void ShouldThrowAnInvalidEmailException(string address)
    {
        Assert.Throws<InvalidEmailException>(() => Email.Create(address));
    }
}