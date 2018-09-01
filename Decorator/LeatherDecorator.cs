namespace Decorator
{
    public class LeatherDecorator : CarDecorator
    {
        private Car car;

        public LeatherDecorator(Car car)
        {
            this.car = car;
            this.Description = "Leather, " + car.Description;
            this.Price = 500 + this.car.Price;
        }

        public override string Description { get; set; }
   
        public override decimal Price { get; set; }
    }
}