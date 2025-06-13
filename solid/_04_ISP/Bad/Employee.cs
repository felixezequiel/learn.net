namespace Solid._04_ISP.Bad;

public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits();
}

public class FullTimeEmployee : IEmployee
{
    public string Name { get; set; }
    public void CalculateSalary()
    {
        Console.WriteLine("Calculate salary for full time employee");
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}

public class ContractEmployee : IEmployee
{
    public string Name { get; set; }
    public void CalculateSalary()
    {
        Console.WriteLine("Calculate salary for contract employee");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Calculate benefits for contract employee");
    }
}