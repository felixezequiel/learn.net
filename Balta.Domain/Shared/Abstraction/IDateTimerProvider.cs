namespace Balta.Domain.Shared.Abstraction;

public interface IDateTimerProvider
{
    #region Properties

    DateTime UtcNow { get; }

    #endregion
}