using Balta.Domain.Shared.ValueObjects.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions;

public sealed class InvalidEmailLengthException(string message) : DomainException(message);
