namespace Domain.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Report" />
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Gets or sets the Product
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Sales
        /// </summary>
        public double Sales { get; set; }

        /// <summary>
        /// The GetReports
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Report}"/></returns>
        public static IEnumerable<Report> GetReports()
        {
            return new Report[]
            {
                new Report
                {
                    Product = "Laptop",
                    Quantity = 15,
                    Sales = 3599.85
                },
                new Report
                {
                    Product = "Desktop",
                    Quantity = 10,
                    Sales = 5449.90
                },
            };
        }
    }
}
