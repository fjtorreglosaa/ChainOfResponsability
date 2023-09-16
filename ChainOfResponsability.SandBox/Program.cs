using ChainOfResponsability.SandBox.Seeders;
using ChainOfResponsability.SandBox.Utilities;

namespace ChainOfResponsability.Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StatusSeeder.Seed();

            ItemSeeder.Seed();

            CreateOrderSandbox.Demo();

            ProcessOrderSandbox.Demo();

            Console.WriteLine("--> TUTORIAL COMPLETED <--");
        }
    }
}