using System.Text.Json.Serialization; 
using System.Collections.Generic; 
using System; 
namespace ClubMateNotifier{ 

    public class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("site_product_image_id")]
        public string SiteProductImageId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("absolute_url")]
        public string AbsoluteUrl { get; set; }

        [JsonPropertyName("urls")]
        public Urls Urls { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("absolute_urls")]
        public AbsoluteUrls AbsoluteUrls { get; set; }

        [JsonPropertyName("placeholder")]
        public bool Placeholder { get; set; }

        [JsonPropertyName("site_product_id")]
        public string SiteProductId { get; set; }

        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("visibility_tl")]
        public string VisibilityTl { get; set; }

        [JsonPropertyName("visibility_locked")]
        public bool VisibilityLocked { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("short_description")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("variation_type")]
        public string VariationType { get; set; }

        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        [JsonPropertyName("product_type_details")]
        public List<object> ProductTypeDetails { get; set; }

        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }

        [JsonPropertyName("required_feature_to_sell")]
        public object RequiredFeatureToSell { get; set; }

        [JsonPropertyName("min_prep_time")]
        public int? MinPrepTime { get; set; }

        [JsonPropertyName("min_prep_time_duration_iso8601")]
        public string MinPrepTimeDurationIso8601 { get; set; }

        [JsonPropertyName("site_shipping_box_id")]
        public object SiteShippingBoxId { get; set; }

        [JsonPropertyName("site_link")]
        public string SiteLink { get; set; }

        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        [JsonPropertyName("seo_page_description")]
        public string SeoPageDescription { get; set; }

        [JsonPropertyName("seo_page_title")]
        public string SeoPageTitle { get; set; }

        [JsonPropertyName("seo_product_image_id")]
        public int? SeoProductImageId { get; set; }

        [JsonPropertyName("og_title")]
        public string OgTitle { get; set; }

        [JsonPropertyName("og_description")]
        public string OgDescription { get; set; }

        [JsonPropertyName("avg_rating")]
        public double? AvgRating { get; set; }

        [JsonPropertyName("avg_rating_all")]
        public double? AvgRatingAll { get; set; }

        [JsonPropertyName("inventory")]
        public Inventory Inventory { get; set; }

        [JsonPropertyName("measurement_unit_abbreviation")]
        public object MeasurementUnitAbbreviation { get; set; }

        [JsonPropertyName("price")]
        public Price Price { get; set; }

        [JsonPropertyName("on_sale")]
        public bool OnSale { get; set; }

        [JsonPropertyName("is_alcoholic")]
        public bool IsAlcoholic { get; set; }

        [JsonPropertyName("import_source")]
        public object ImportSource { get; set; }

        [JsonPropertyName("per_order_max")]
        public object PerOrderMax { get; set; }

        [JsonPropertyName("created_date")]
        public DateTime CreatedDate { get; set; }

        [JsonPropertyName("updated_date")]
        public DateTime UpdatedDate { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("placeholder_image")]
        public PlaceholderImage PlaceholderImage { get; set; }
    }

}