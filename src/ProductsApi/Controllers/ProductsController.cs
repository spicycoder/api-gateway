namespace ProductsApi.Controllers
{
    using Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ProductsController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// The GetProducts
        /// </summary>
        /// <returns>The <see cref="ActionResult{IEnumerable{Product}}"/></returns>
        [HttpGet("")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = Product.GetProducts();
            return Ok(products);
        }
    }
}
