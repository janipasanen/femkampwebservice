using FemkampApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FemkampApp.Controllers
{
    public class FemkampController : ApiController
    {
        Femkamp[] femkamp = new Femkamp[]
        {
            new Femkamp { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Femkamp { Id = 2, Name = "Yo-yo", Category = "Groceries", Price = 3.75M },
            new Femkamp { Id = 3, Name = "Hammer", Category = "Groceries", Price = 16.99M },
        };

        public IEnumerable<Femkamp> GetAllProducts()
        {
            return femkamp;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var femkamp = femkamp.FirstOrDefault((p) => p.Id == id);
            if (femkamp == null)
            {
                return NotFound();
            }
            return Ok(femkamp);
        }
    }
}
