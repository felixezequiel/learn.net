using Balta.Domain.Shared.ValueObjects.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions;

public class InvalidLastNameLengthException(string message) : DomainException(message);