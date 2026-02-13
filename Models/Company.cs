
using System.Text.Json.Serialization;

namespace TimeSheet.Models
{
    public class Company
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("pay_rate")]
        public decimal? PayRate { get; set; }
    }

    public class CompaniesResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("companies")]
        public List<Company> Companies { get; set; } = new List<Company>();
    }
}
