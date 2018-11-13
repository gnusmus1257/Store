using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Entity.models
{
    public class Product : Entity
    {
        public float Price { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        [NotMapped]
        public IFormFile UploadedImage { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Specification> Specifications { get; set; }
    }
}
