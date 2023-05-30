using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PortalTransparenciaDeps.SharedKernel.Interfaces
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
