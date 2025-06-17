using Balta.Domain.Shared.Events.Abstraction;

namespace Balta.Domain.Accounts.Events;

public sealed record OnStudentCreatedEvent(Guid Id, string Name, string Email) : IDomainEvent;