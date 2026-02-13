using System.Text.Json.Serialization;

namespace TimeSheet.Models
{
    public class GetEntriesResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("entries")]
        public List<Entry> Entries { get; set; }
    }

    public class Entry
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("entry_date")]
        public string EntryDate { get; set; }

        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        [JsonPropertyName("duration_minutes")]
        public int DurationMinutes { get; set; }

        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        [JsonPropertyName("category_description")]
        public string CategoryDescription { get; set; }

        [JsonPropertyName("category_id")]
        public int? CategoryId { get; set; }

        [JsonPropertyName("project_code")]
        public string ProjectCode { get; set; }

        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }

        [JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonPropertyName("company_id")]
        public int? CompanyId { get; set; }

        // DB uses 0/1 for billable; keep as int to match DTO exactly
        [JsonPropertyName("billable")]
        public int Billable { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
