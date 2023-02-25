using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDOperations.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required (ErrorMessage ="Product Name is Required.")]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is Required.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Quantity is Required.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "ReMarks is Required.")]
        [Display(Name = "ReMarks")]
        public String ReMarks { get; set; }
    }
    public class EFCodeFirstEntities:DbContext
    {
        public DbSet<Products> products { get; set; }
    }
}