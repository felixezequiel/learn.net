using Balta.Domain.Shared.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed record Name : ValueObject
{
    public const int MinLength = 2;
    public const int MaxLength = 20;
    
    #region Contructor
    private Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion

    #region Factories

    public static Name Create(string firstName, string lastName)
    {
        if (firstName.Length < MinLength)
        {
            throw new InvalidFirstNameLengthException($"first name must be at least {MinLength} characters long.");
        }

        if (firstName.Length > MaxLength)
        {
            throw new InvalidFirstNameLengthException($"first name must be at most {MaxLength} characters long.");
        }

        if (lastName.Length < MinLength)
        {
            throw new InvalidLastNameLengthException($"last name must be at least {MinLength} characters long.");
        }

        if (lastName.Length > MaxLength)
        {
            throw new InvalidLastNameLengthException($"last name must be at most {MaxLength} characters long.");
        }
        
        return new Name(firstName, lastName);
    }
    
    #endregion
    
    #region Properties
    
    public string FirstName { get; }
    public string LastName { get; }
    
    #endregion

    #region Operators

    public static implicit operator string(Name name) => name.ToString();

    #endregion

    #region Overrides

    public override string ToString() => $"{FirstName} {LastName}";

    #endregion

}