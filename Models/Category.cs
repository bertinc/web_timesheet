using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace TimeSheet.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class CategoriesResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
