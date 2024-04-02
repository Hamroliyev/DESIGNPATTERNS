using FactoryMehtod.Services;

namespace FactoryMehtod.Logistics
{
    public interface ILogistics
    {
        void PlanDeleviry();
        ITransport CreateTransport();
    }
}
