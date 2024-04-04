using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AbstractFactory.Services.ProductReaders
{
    public class FileProductReader : IProductReader
    {
        private readonly ICollection<Product> products;

        private bool disposed;

        public FileProductReader(string fileName)
        {
            try
            {
                string productsJson = File.ReadAllText(fileName);
                products = JsonSerializer.Deserialize<ICollection<Product>>(productsJson);
            }
            catch (FileNotFoundException)
            {
                products = new List<Product>();
            }
        }

        public Product GetById(Guid id)
        {
            if (disposed)
            {
                throw new Exception("Object is disposed.");
            }

            Product product = products.FirstOrDefault(p => p.Id == id);

            bool productNotFound = product == null;
            if (productNotFound)
            {
                throw new Exception("Product not found.");
            }

            return product;
        }

        public void Dispose()
        {
            disposed = true;
            products.Clear();
        }
    }
}
