using Balta.Domain.Shared.Abstraction;

namespace Balta.Domain.Shared;

public class DateTimerProvider :  IDateTimerProvider
{
    public DateTime UtcNow { get; } = DateTime.UtcNow;
}