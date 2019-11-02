namespace Domain.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Product" />
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The GetProducts
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Product}"/></returns>
        public static IEnumerable<Product> GetProducts()
        {
            return new Product[]
            {
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Laptop",
                    Price = 239.99
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Desktop",
                    Price = 544.99
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Smart phone",
                    Price = 239.99
                }
            };
        }
    }
}
