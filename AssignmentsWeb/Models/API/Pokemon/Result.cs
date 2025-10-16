using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Pokemon
{
    public class Result
    {
        // Usage for the pokemon API
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
