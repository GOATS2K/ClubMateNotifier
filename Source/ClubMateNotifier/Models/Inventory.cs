using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class Inventory
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("lowest")]
        public int Lowest { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("marked_sold_out_at_all_existing_locations")]
        public bool MarkedSoldOutAtAllExistingLocations { get; set; }

        [JsonPropertyName("marked_sold_out_skus_count")]
        public int MarkedSoldOutSkusCount { get; set; }

        [JsonPropertyName("has_location_not_tracking")]
        public bool HasLocationNotTracking { get; set; }
    }

}