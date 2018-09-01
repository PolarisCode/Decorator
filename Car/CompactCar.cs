public class CompactCar : Car
{
    public CompactCar()
    {
        Description = "Compact Car";
        Price = 1000;
    }
    public override string Description
    {
        get; set;
    }
    public override decimal Price
    {
        get; set;
    }
}