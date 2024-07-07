using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace projectDaedalus.Models
{
    public class PlayerCharacter
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id {  get; set; }
    public string player { get; set; } = null!;

    [BsonElement("character")]
    [JsonPropertyName("character")]
    public List<string> characterIds { get; set; } = null!;
}
}
