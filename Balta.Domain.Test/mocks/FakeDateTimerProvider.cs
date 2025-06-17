using Balta.Domain.Shared.Abstraction;

namespace Balta.Domain.Test.mocks;

public class FakeDateTimerProvider : IDateTimerProvider
{
    public DateTime UtcNow { get; } = new (2025, 06,14);
}