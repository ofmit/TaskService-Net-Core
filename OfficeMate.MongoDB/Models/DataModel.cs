using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OfficeMate.MongoDB.Models
{
    public class LogRT
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

    public class LogRTV
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

    public class LogRD
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

    public class LogGR
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

    public class LogDL
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

    public class LogSSR
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

    public class LogSR
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
    public class LogPW
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
    public class LogWT
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
    public class LogSI
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
    public class LogDR
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

	public class LogRU
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

    public class LogTD
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
    public class LogAQ
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
    public class LogCN
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
    public class LogSSO
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

    public class LogSPW
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

    public class LogPIC
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

    public class LogIC
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

    public class LogPSI
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

    public class LogTR
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

    public class LogSTR
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

    public class LogPTS
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

    public class LogSTS
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

    public class LogTS
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

    public class LogPTR
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

    public class LogPRU
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

    public class LogSRU
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

    public class LogPPR
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

    public class LogPR
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
    public class LogLT
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

    public class LogPLT
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
