using MongoDB.Bson;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;

namespace PortalTransparenciaDeps.SharedKernel
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
