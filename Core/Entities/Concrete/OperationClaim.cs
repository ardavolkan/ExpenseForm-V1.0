using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Concrete
{
    public class OperationClaim :IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

    }

       

}
