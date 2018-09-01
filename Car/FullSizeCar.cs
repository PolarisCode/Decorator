public class FullSizeCar : Car
{
    public FullSizeCar()
    {
        Description = "Full size car";
        Price = 2000;
    }

    public override string Description { get; set; }
    public override decimal Price { get; set; }
} 