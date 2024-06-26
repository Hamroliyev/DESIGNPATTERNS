﻿using AbstractFactory.Models;
using AbstractFactory.Services;
using System;

namespace AbstractFactory
{
    public class Program
    {
        private const string FILE_NAME = "products.json";

        public static void Main(string[] args)
        {
            IProductCommunicatorAbstractFactory productCommunicatorAbstractFactory = new InMemoryProductCommunicatorAbstractFactory();
            ProductService productService = new ProductService(productCommunicatorAbstractFactory);

            try
            {
                Product product = productService.GetById(new Guid("34cb0113-2b54-4f86-98bc-a1a70d5817fd"));
                Console.WriteLine(product);
            }
            catch (Exception)
            {
                Console.WriteLine("Product not found.");
            }

            try
            {
                Product savedProduct = productService.Save(new Product()
                {
                    Name = "Desk",
                    Price = 49.99
                });
                Console.WriteLine(savedProduct);
            }
            catch (Exception)
            {
                Console.WriteLine("Product saved failed.");
            }
        }
    }
}