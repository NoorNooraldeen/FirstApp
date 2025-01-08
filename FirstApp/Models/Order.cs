namespace FirstApp.Models
{
    public class Order: BaseProp
    {
        public int OrdereId { get; set; } // primary key
        public int OrderDate { get; set; }

        public int CostomerId { get; set; }
        public string Product { get; set; }

        public int Amount { get; set; }

    }
}
