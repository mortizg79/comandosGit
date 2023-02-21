namespace ComandosGitWebAPI.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
    }
}
