using System;
using AbstractFactory.Models;

namespace AbstractFactory.Services.ProductWriters
{
    public interface IProductWriter : IDisposable
    {
        Product Save(Product product);
    }
}
