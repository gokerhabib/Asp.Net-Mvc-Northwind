using System.Collections.Generic;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentCategory { get; set; }
    }
}