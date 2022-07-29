using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

}