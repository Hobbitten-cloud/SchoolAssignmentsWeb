using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class Root
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("mimetype")]
        public string Mimetype { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }


}
