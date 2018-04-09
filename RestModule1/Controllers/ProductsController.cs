using RestModule1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestModule1.Controllers
{
    public class ProductsController : ApiController
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id = 0, ProductName = "Apple", Price = 20},
            new Product(){Id = 1, ProductName = "Banana", Price = 20},
            new Product(){Id = 2, ProductName = "Orange", Price = 20},
            new Product(){Id = 3, ProductName = "Grape", Price = 20}
        };

        // GET: api/Products
        // Example shoes that as long as a GET HTTP verb is in place you can add another name with like below Get..Products
        [HttpGet]
        public IHttpActionResult LoadProducts()
        {
            return Ok(products);
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return products[id];
        }

        // POST: api/Products
        // HttpResponseMessage added and void removed. 
        public HttpResponseMessage Post([FromBody]Product product)
        {
            products.Add(product);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // PUT: api/Products/5
        // Example of FromUri instead of FromBody
        //FromUri: You can pass data from URI
        public void Put(int id, [FromUri]Product product)
        {
            products[id] = product;
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            products.RemoveAt(id);

        }
    }
}
