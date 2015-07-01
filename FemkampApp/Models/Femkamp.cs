using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FemkampApp.Models
{
    public class Femkamp     
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}


// Source: http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api