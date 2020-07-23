using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AspNetMvcNorthwind.Entities
{
    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }
    }
}