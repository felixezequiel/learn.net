using System.Text.RegularExpressions;
using Balta.Domain.Accounts.ValueObjects.Exceptions;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed partial record Email : ValueObject
{
    #region Constants

    private const string Pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
    
    public const int MinLength = 6;
    
    public const int MaxLength = 160;

    #endregion

    #region Constructor

    public Email(string address)
    {
        Address = address;
    }

    #endregion

    #region Factories

    public static Email Create(string address)
    {
        if (string.IsNullOrEmpty(address) || string.IsNullOrWhiteSpace(address))
        {
            throw new InvalidEmailLengthException("Email cannot be null or empty");
        }

        if (address.Length < MinLength || address.Length > MaxLength)
        {
            throw new InvalidEmailException($"Email address length must be between {MinLength} and {MaxLength} characters");
        }

        address = address.Trim();
        address = address.ToLower();

        if (!EmailRegex().IsMatch(address))
        {
            throw new InvalidEmailException("Invalid email address.");
        }
        
        return new Email(address);
    }


    #endregion

    #region Properties

    public string Address { get; }

    #endregion

    #region Source Generators

    [GeneratedRegex(Pattern)]
    private static partial Regex EmailRegex();

    #endregion

    #region Operators

    public static implicit operator string(Email email) => email.ToString();

    #endregion

    #region Overrides

    public override string ToString() => Address;

    #endregion
}