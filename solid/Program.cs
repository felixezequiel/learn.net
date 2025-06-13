using Solid._02_OCP.Good;
using Solid._03_LSP.Good;
using Solid._04_ISP.Good;
using Solid._05_DIP.Good;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// OCP
var discount = new EletronicsDiscount();
var price = discount.Calculate(1000);
Console.WriteLine(price);

// LSP
var savingsAccount = new SavingsAccount();
savingsAccount.Withdraw(100);

// ISP
var fullTimeEmployee = new FullTimeEmployee();
fullTimeEmployee.CalculateSalary();
fullTimeEmployee.CalculateBenefits();

var contractEmployee = new ContractEmployee();
contractEmployee.CalculateSalary();

// DIP
var emailService = new FakeEmailService();
var userService = new UserService(emailService);
userService.Register("test@test.com", "123456");
