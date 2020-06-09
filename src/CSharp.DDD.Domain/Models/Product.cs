namespace CSharp.DDD.Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public long PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}