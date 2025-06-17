using Balta.Domain.Shared.ValueObjects;
using Balta.Domain.Test.mocks;

namespace Balta.Domain.Test.Accounts.ValueObjects;

public class TrackerTest
{
    [Fact]
    public void ShouldCreateTrackerWithCurrentUtcDateTime()
    {
        var fakeDateTimer = new FakeDateTimerProvider();
        var tracker = Tracker.Create(fakeDateTimer);
        
        Assert.Equal(fakeDateTimer.UtcNow, tracker.CreatedAtUTC);
    }
}