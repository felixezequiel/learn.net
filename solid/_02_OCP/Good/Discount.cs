namespace Solid._02_OCP.Good;

public abstract class Discount
{
    public abstract decimal Calculate(decimal price);
}

public class EletronicsDiscount : Discount
{
    public override decimal Calculate(decimal price)
    {
        return price * 0.9m;
    }
}

public class HealthDiscount : Discount
{
    public override decimal Calculate(decimal price)
    {
        return price * 0.8m;
    }
}

public class BeautyDiscount : Discount
{
    public override decimal Calculate(decimal price)
    {
        return price * 0.7m;
    }
}

public class FashionDiscount : Discount
{
    public override decimal Calculate(decimal price)
    {
        return price * 0.6m;
    }
}