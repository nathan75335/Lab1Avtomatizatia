namespace Lab1.Data.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }  
        public List<Group>? Groups { get; set; }
    }
}
