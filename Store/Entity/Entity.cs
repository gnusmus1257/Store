using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Entity
    {
        public string Name { get; set; }

        [Key]
        public Guid Id { get; set; }
    }
}
