using FactoryMehtod.Services;

namespace FactoryMehtod.Logistics
{
    public class RoadLogistics : ILogistics
    {
        private ITransport transport;
        public ITransport CreateTransport()
        {
            return new Truck();
        }

        public void PlanDeleviry()
        {
            this.transport = CreateTransport();
        }
    }
}
