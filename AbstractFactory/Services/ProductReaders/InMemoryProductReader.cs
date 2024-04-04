using AbstractFactory.Models;
using System;

namespace AbstractFactory.Services.ProductReaders
{
    public class InMemoryProductReader : IProductReader
    {
        public void Dispose() { }

        public Product GetById(Guid id)
        {
            return new Product()
            {
                Id = id,
                Name = "Dog",
                Price = 5
            };
        }
    }
}
