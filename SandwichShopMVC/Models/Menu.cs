using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandwichShopMVC.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public int Quantity { get; set; }
       

        public virtual ICollection<UpdateSales> Inventory { get; set; }
      
    }
}