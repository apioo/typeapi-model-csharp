using System.Text.Json.Serialization;

namespace TypeAPI.Model;

public class Response
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("schema")]
    public TypeSchema.Model.PropertyType? Schema { get; set; }

}

