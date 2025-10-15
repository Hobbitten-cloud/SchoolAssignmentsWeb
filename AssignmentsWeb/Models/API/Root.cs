using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API
{
    public class Root
    {
        [JsonPropertyName("quote")]
        public string Quote { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }
    }
}
