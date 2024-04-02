using FactoryMehtod.Services;

namespace FactoryMehtod.Logistics
{
    internal class SeaLogistics : ILogistics
    {
        private ITransport transport;
        public ITransport CreateTransport()
        {
            return new Ship();
        }

        public void PlanDeleviry()
        {
            this.transport = CreateTransport();
        }
    }
}
