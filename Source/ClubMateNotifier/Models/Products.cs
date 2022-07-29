using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace ClubMateNotifier{ 

    public class Products
    {
        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

}