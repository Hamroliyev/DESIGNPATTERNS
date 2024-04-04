using AbstractFactory.Services.ProductReaders;
using AbstractFactory.Services.ProductWriters;

namespace AbstractFactory.Services
{
    public class FileProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        private readonly string _fileName;

        public FileProductCommunicatorAbstractFactory(string fileName)
        {
            _fileName = fileName;
        }

        public IProductReader CreateProductReader()
        {
            return new FileProductReader(_fileName);
        }

        public IProductWriter CreateProductWriter()
        {
            return new FileProductWriter(_fileName);
        }
    }
}
