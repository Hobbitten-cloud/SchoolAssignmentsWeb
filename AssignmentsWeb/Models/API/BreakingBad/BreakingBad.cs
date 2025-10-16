using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.BreakingBad
{
    public class BreakingBad
    {
        // Breaking bad quotes API
        [JsonPropertyName("quote")]
        public string Quote { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }
    }
}
