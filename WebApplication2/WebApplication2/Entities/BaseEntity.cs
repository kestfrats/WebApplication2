namespace WebApplication2.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
