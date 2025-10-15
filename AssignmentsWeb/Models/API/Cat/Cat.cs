using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Cat
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class Cat
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mimetype")]
        public string Mimetype { get; set; }
    }


}
