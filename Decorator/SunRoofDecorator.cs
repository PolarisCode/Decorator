namespace Decorator
{
    internal class SunRoof : CarDecorator
    {
        private Car _car;

        public SunRoof(Car leatherDecorator)
        {
            this._car = leatherDecorator;
            this.Description = "SunRoof, " + _car.Description;
            this.Price = 1000 + _car.Price;
        }

        public override string Description { get; set; }
        public override decimal Price { get; set; }
    }
}