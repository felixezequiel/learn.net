using Balta.Domain.Accounts.Events;
using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Shared.Abstraction;
using Balta.Domain.Shared.Entities;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.Entities;

public sealed class Student : Entity
{
    #region Constructor

    private Student(
        Name name,
        Email email,
        string password,
        IDateTimerProvider dateTimerProvider) : base(Guid.NewGuid())
    {
        Name = name;
        Email = email;
        Password = password;
        Tracker = Tracker.Create(dateTimerProvider);
    }

    #endregion

    #region Factories

    public static Student Create(
        string firstName, 
        string lastName, 
        string email,
        string password, 
        IDateTimerProvider dateTimerProvider)
    {
        var student = new Student(Name.Create(firstName, lastName), Email.Create(email), password, dateTimerProvider);
           
        student.RaiseEvents(new OnStudentCreatedEvent(student.Id, student.Name, student.Email));
        
        return student;
    }

    #endregion

    #region Properties
    
    public Name Name { get; }
    public Email Email { get; }
    public string Password { get; } = string.Empty;
    
    public Tracker Tracker { get; }
    
    #endregion

    #region Overrides

    public override string ToString() => Name;

    #endregion
}