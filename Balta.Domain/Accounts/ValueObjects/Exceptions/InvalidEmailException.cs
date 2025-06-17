using Balta.Domain.Shared.ValueObjects.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions;

public class InvalidEmailException(string message) : DomainException(message);