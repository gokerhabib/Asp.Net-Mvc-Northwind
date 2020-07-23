using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AspNetMvcNorthwind.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public Int16 UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        [Required]
        public int CategoryID { get; set; }
    }
}
