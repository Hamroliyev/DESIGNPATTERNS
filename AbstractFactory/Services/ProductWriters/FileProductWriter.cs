using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AbstractFactory.Services.ProductWriters
{
    public class FileProductWriter : IProductWriter
    {
        private readonly ICollection<Product> products;

        private bool disposed;

        public FileProductWriter(string fileName)
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

        public Product Save(Product product)
        {
            if (disposed)
            {
                throw new Exception("Object is disposed.");
            }

            product.Id = Guid.NewGuid();

            products.Add(product);

            string productsJson = JsonSerializer.Serialize(products);
            File.WriteAllText("products.json", productsJson);

            return product;
        }

        public void Dispose()
        {
            disposed = true;
            products.Clear();
        }
    }
}
