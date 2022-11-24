using System.Text.Json.Serialization;

namespace BlazorRadzenGridTests.BlazorApp.Models
{
    public class ODataPagedResultModel<T>
    {
        public List<T> Value { get; set; }
        [JsonPropertyName("@odata.count")]
        public int TotalSize { get; set; }
    }
}
