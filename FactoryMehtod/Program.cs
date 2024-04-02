using FactoryMehtod.Logistics;

namespace FactoryMehtod
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ILogistics logistics = new RoadLogistics();
            logistics.CreateTransport().Deliver();
            Console.WriteLine();
            logistics = new SeaLogistics();
            logistics.CreateTransport().Deliver();
            Console.ReadKey();
        }
    }
}
