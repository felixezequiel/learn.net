namespace Balta.Domain.Shared.ValueObjects.Exceptions;

public abstract class DomainException(string message) : Exception(message);