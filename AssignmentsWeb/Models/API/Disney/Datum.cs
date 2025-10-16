using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Disney
{
    public class Datum
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("films")]
        public List<string> Films { get; set; }

        [JsonPropertyName("shortFilms")]
        public List<string> ShortFilms { get; set; }

        [JsonPropertyName("tvShows")]
        public List<string> TvShows { get; set; }

        [JsonPropertyName("videoGames")]
        public List<string> VideoGames { get; set; }

        [JsonPropertyName("parkAttractions")]
        public List<string> ParkAttractions { get; set; }

        [JsonPropertyName("allies")]
        public List<object> Allies { get; set; }

        [JsonPropertyName("enemies")]
        public List<object> Enemies { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
