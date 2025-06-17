using Balta.Domain.Shared.Abstraction;

namespace Balta.Domain.Shared.ValueObjects;

public sealed record Tracker : ValueObject
{
    #region Contructors
    
    private Tracker(DateTime createdAt, DateTime updatedAt)
    {
        CreatedAtUTC = createdAt;
        UpdatedAtUTC = updatedAt;
    }

    #endregion

    #region Properties
    public DateTime CreatedAtUTC { get; }
    public DateTime UpdatedAtUTC { get; private set; }

    #endregion

    #region Factories

    public static Tracker Create(IDateTimerProvider dateTimerProvider) => new(dateTimerProvider.UtcNow, dateTimerProvider.UtcNow);

    public static Tracker Create(DateTime createdAt, DateTime updatedAt) => new(createdAt, updatedAt);

    #endregion

    #region Public methods
    
    public void Update(IDateTimerProvider dateTimerProvider)
    {
        UpdatedAtUTC = dateTimerProvider.UtcNow;
    }
    
    #endregion

}