using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class PlaceholderImage
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

}