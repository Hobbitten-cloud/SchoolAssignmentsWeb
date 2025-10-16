using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Disney
{
    public class Info
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("previousPage")]
        public string PreviousPage { get; set; }

        [JsonPropertyName("nextPage")]
        public string NextPage { get; set; }
    }
}
