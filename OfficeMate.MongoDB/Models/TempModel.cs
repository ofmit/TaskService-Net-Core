using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OfficeMate.MongoDB.Models
{
    public class TempRT
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }
    public class TempRTV
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }
    public class TempGR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempRD
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempSR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempSSR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempDL
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempDR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPW
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempRU
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempWT
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempCN
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempSI
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempSSO
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempTD
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPIC
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempIC
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPSI
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempTR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPTS
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPRU
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempSRU
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPTR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }
    public class TempPPR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }

    public class TempPR
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string JsonData { get; set; } = string.Empty;
        public DateTime ActionOn { get; set; } = DateTime.Now;
        public string ActionBy { get; set; } = string.Empty;
        public string ActionByName { get; set; } = string.Empty;
    }
}
