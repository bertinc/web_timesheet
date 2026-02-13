using System.Text.Json.Serialization;

namespace TimeSheet.Models
{
    /// <summary>
    /// Represents the JSON response from the `/gethoursandpay` endpoint.
    /// JSON shape: { "hours": <number>, "pay": <number> }
    /// </summary>
    public class GetHoursAndPayResponse
    {
        [JsonPropertyName("hours")]
        public double Hours { get; set; } = 0.0;

        [JsonPropertyName("pay")]
        public double Pay { get; set; } = 0.0;
    }
}
