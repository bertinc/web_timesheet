using System.Text.Json.Serialization;

namespace TimeSheet.Models
{
    public class AddEntryResponse
    {
        [JsonPropertyName("inserted")]
        public int? Inserted { get; set; } = null;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;
    }
}
