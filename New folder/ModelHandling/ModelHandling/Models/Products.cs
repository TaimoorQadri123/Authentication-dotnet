using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelHandling.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductCatDescription { get; set; }

        public double Price { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]

        [ValidateNever]

        public Category Category { get; set; }



            


    }
}
