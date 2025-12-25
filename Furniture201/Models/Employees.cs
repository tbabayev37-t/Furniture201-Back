namespace Furniture201.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Postion { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; } //https://localhost:7199/assets/images/person_1.jpg
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<Blog> Blogs { get; internal set; }
    }
}
