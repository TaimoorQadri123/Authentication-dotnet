namespace ModelHandling.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string userId { get; set; }

        public int ProductId { get; set; }

        public Products? Products { get; set; }

        public int Quantity {  get; set; }

        public int Price {  get; set; }
    }
}
