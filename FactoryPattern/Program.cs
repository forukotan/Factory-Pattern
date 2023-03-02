namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make");
            
            int wheels =int.Parse( Console.ReadLine());

            var newVehicle = VehicleFactory.GetVehicle(wheels);

            newVehicle.drive();
        }
    }
}
