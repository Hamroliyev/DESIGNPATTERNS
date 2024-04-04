using AbstractFactory.Services.ProductReaders;
using AbstractFactory.Services.ProductWriters;

namespace AbstractFactory.Services
{
    public class InMemoryProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        public IProductReader CreateProductReader()
        {
            return new InMemoryProductReader();
        }

        public IProductWriter CreateProductWriter()
        {
            return new InMemoryProductWriter();
        }
    }
}
