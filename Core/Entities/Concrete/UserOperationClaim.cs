using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Concrete
{
   public class UserOperationClaim :IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OperationClaimId { get; set; }
    }

       

}
