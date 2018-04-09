using RestModule1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestModule1.Controllers
{
    public class CustomersController : ApiController
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id =1, Name = "Tom C", Email = "tom@gmail.com", Phone ="3222"},
            new Customer(){Id=2, Name="Jill D", Email="Jill@gmail.com", Phone="4422"},
            new Customer(){Id=3, Name="Bruce E", Email="Bruce@gmail.com", Phone="5522"},
            new Customer(){Id=4, Name="Andrew F", Email="Andrew@gmail.com", Phone="5522"}
        };


        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody] Customer customer)
        {
            customers.Add(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
