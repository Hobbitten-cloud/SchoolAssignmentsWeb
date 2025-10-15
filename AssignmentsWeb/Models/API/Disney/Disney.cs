using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace AssignmentsWeb.Models.API.Disney
{
    public class Disney
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
    }
}
