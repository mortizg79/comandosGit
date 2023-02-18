namespace ComandosGitWebAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public int PostalCode { get; set; }
        public int NumberExt { get; set; }
        public int NumberInt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
