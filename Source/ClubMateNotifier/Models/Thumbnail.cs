using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class Thumbnail
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

}