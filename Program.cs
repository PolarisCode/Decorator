using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new CompactCar();
            c = new LeatherDecorator(c);
            //c = new SunRoof(c);

            System.Console.WriteLine(c.Description);
            System.Console.WriteLine(c.Price);

        }
    }
}
