namespace Solid._02_OCP.Bad;

public enum EProductType
{
    Eletronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4,
}

public class Discount
{
    public decimal Calculate(EProductType productType, decimal price)
    {   
        if (productType == EProductType.Eletronics)
        {
            return price * 0.9m;
        }
        
        if (productType == EProductType.Health)
        {
            return price * 0.8m;
        }

        if (productType == EProductType.Beauty)
        {
            return price * 0.7m;
        }

        if (productType == EProductType.Fashion)
        {
            return price * 0.6m;
        }

        return price;
    }
}