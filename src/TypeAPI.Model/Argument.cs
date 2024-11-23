using System.Text.Json.Serialization;

namespace TypeAPI.Model;

public class Argument
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("in")]
    public string? In { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("schema")]
    public TypeSchema.Model.PropertyType? Schema { get; set; }

}

