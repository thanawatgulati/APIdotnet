namespace APIdotnet.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; } // Relation [Key]
        public int SupplierID { get; set; } // Relation [Key]
        public Category ProductCategory { get; set; }
        public Supplier ProductSupplier { get; set; }
    }
}