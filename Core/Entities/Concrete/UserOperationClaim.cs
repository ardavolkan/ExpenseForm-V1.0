using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Concrete
{
   public class UserOperationClaim :IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }

       

}
