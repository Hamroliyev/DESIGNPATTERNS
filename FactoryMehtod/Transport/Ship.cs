namespace FactoryMehtod.Services
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Sea in a container");
        }
    }
}
