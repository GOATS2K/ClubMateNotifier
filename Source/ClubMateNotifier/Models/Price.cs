using System.Text.Json.Serialization; 
namespace ClubMateNotifier{ 

    public class Price
    {
        [JsonPropertyName("high")]
        public int High { get; set; }

        [JsonPropertyName("high_with_modifiers")]
        public int HighWithModifiers { get; set; }

        [JsonPropertyName("high_formatted")]
        public string HighFormatted { get; set; }

        [JsonPropertyName("high_formatted_with_modifiers")]
        public string HighFormattedWithModifiers { get; set; }

        [JsonPropertyName("high_subunits")]
        public int HighSubunits { get; set; }

        [JsonPropertyName("low")]
        public int Low { get; set; }

        [JsonPropertyName("low_with_modifiers")]
        public int LowWithModifiers { get; set; }

        [JsonPropertyName("low_formatted")]
        public string LowFormatted { get; set; }

        [JsonPropertyName("low_formatted_with_modifiers")]
        public string LowFormattedWithModifiers { get; set; }

        [JsonPropertyName("low_subunits")]
        public int LowSubunits { get; set; }

        [JsonPropertyName("regular_high")]
        public int RegularHigh { get; set; }

        [JsonPropertyName("regular_high_with_modifiers")]
        public int RegularHighWithModifiers { get; set; }

        [JsonPropertyName("regular_high_formatted")]
        public string RegularHighFormatted { get; set; }

        [JsonPropertyName("regular_high_formatted_with_modifiers")]
        public string RegularHighFormattedWithModifiers { get; set; }

        [JsonPropertyName("regular_high_subunits")]
        public int RegularHighSubunits { get; set; }

        [JsonPropertyName("regular_low")]
        public int RegularLow { get; set; }

        [JsonPropertyName("regular_low_with_modifiers")]
        public int RegularLowWithModifiers { get; set; }

        [JsonPropertyName("regular_low_formatted")]
        public string RegularLowFormatted { get; set; }

        [JsonPropertyName("regular_low_formatted_with_modifiers")]
        public string RegularLowFormattedWithModifiers { get; set; }

        [JsonPropertyName("regular_low_subunits")]
        public int RegularLowSubunits { get; set; }
    }

}