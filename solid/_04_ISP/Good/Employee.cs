namespace Solid._04_ISP.Good;

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculator
{
    void CalculateBenefits();
}

public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
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

public class ContractEmployee : ISalaryCalculator
{
    public string Name { get; set; }
    public void CalculateSalary()
    {
        Console.WriteLine("Calculate salary for contract employee");
    }
}