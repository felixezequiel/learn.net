using Balta.Domain.Accounts.Entities;
using Balta.Domain.Test.mocks;

namespace Balta.Domain.Test.Accounts.Entities;

public class StudentTest
{   
    [Fact]
    public void Test1()
    {
        var dateTimeProvider = new FakeDateTimerProvider();
        var student = Student.Create(
            "John", 
            "Doe", 
            "test@test.com", 
            "12345",
            dateTimeProvider);
        
        
    }
}