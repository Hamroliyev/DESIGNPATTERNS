using AbstractFactory.Models;
using System;

namespace AbstractFactory.Services.ProductWriters
{
    public class InMemoryProductWriter : IProductWriter
    {
        public void Dispose() { }

        public Product Save(Product product)
        {
            product.Id = Guid.NewGuid();
            return product;
        }
    }
}
