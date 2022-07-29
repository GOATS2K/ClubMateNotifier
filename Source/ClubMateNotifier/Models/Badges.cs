using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class Badges
    {
        [JsonPropertyName("low_stock")]
        public bool LowStock { get; set; }

        [JsonPropertyName("out_of_stock")]
        public bool OutOfStock { get; set; }

        [JsonPropertyName("on_sale")]
        public bool OnSale { get; set; }
    }

}