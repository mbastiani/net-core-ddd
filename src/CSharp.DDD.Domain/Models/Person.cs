using System.Collections;
using System.Collections.Generic;

namespace CSharp.DDD.Domain.Models
{
    public class Person : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}