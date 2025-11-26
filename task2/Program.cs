namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 150,
                Seats = 5
            };

            // Create Motorcycle object
            Motorcycle moto = new Motorcycle
            {
                Brand = "Honda",
                Speed = 120,
                HasCarrier = true
            };

            // Demonstrating code reusability
            Console.WriteLine("=== Car Info ===");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine("\n=== Motorcycle Info ===");
            moto.Start();
            moto.DisplayInfo();
            moto.Stop();
        
    }
    }
}
