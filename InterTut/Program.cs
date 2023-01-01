namespace InterTut
{
    interface IMovable
    {
        void Move();
    }

    interface IBuyable
    {
        decimal Price { get; }
        void Buy();
    }

    class Car : IMovable, IBuyable
    {
        public decimal Price { get; set; }
        public Car(decimal price)
        {
            Price = price;
        }

        public void Buy()
        {
            Console.WriteLine("You bought a car for {0}", Price);

        }

        public void Move()
        {
            Console.WriteLine("VROOOOOM");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}