namespace Lab1.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

    }
}
