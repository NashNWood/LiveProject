using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichShopMVC.Models
{
    public class ViewModel
    {
        public Menu Menu { get; set;}
        public IEnumerable<Ingredients> Ingredients { get; set;}
        public UpdateSales UpdateSales { get; set; }
    }
}