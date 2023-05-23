namespace Domain.Entities
{

    public class Product
    {
        public int EnterpriseCode { get; set; }
        public int ProductId { get; set; }
        public string? PartNumber { get; set; }
        public string? Name { get; set; }
        public bool LastLevel { get; set; }
        public string? Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
