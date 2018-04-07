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
        // Returning other custome status code. This shoes Created which means when you add something to the sever when its created server sends response saying created.
        public HttpRequestMessage Get()
        {
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return products[id];
        }

        // POST: api/Products
        public void Post([FromBody]Product product)
        {
            products.Add(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
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
