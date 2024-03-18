using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            var product = new List<Product>
            {
                new Product{ Id= 1, Title="11inch Macbook Air", Category= "Electronics", Date="26th December",
                Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo, aliquam!",
                Rating=4, Imagepath="https://localhost:44318/Image/products-1.jpg"},

                new Product{ Id= 2, Title="Full Study Table Combo", Category= "Furnitures", Date="26th December",
                Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo, aliquam!",
                Rating=4, Imagepath="https://localhost:44318/Image/products-2.jpg"},

                new Product{ Id= 3, Title="11inch Macbook Air", Category= "Electronics", Date="26th December",
                Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo, aliquam!",
                Rating=4, Imagepath="https://localhost:44318/Image/products-3.jpg"}
            };
            return product;
        }
    }
}
