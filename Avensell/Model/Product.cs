namespace Avensell.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        public Boolean Discontinued { get; set; }
    }
}
