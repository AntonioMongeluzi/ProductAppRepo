using MongeluziAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace MongeluziAPI.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { ID = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Product { ID = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product { ID = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        public ProductController()
        {

        }
        


        public ProductController(Product[] products)
        {
            this.products = products;
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
