using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Pokemon
{
    public class Pokemon
    {
        // PokemonAPI
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }
}
