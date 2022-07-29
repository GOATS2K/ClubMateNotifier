using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class AbsoluteUrls
    {
        [JsonPropertyName("80")]
        public string _80 { get; set; }

        [JsonPropertyName("160")]
        public string _160 { get; set; }

        [JsonPropertyName("320")]
        public string _320 { get; set; }

        [JsonPropertyName("600")]
        public string _600 { get; set; }
    }

}