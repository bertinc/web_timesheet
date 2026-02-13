using System.Text.Json.Serialization;

namespace TimeSheet.Models
{
    public class Project
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("due_date")]
        public string? DueDate { get; set; }

        [JsonPropertyName("company_id")]
        public int? CompanyId { get; set; }

        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class ProjectsResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
