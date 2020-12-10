using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectDOTNET.Models
{
    public class Equation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("equation")]
        public string EquationToBeSolved { get; set; }
        [BsonElement("image")]
        public string ImageEncoding { get; set; }
    }
}
