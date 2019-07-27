using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
// using OfficeMate.BusinessLogic.Services;
// using OfficeMate.BusinessLogic.Services.Interface;
using OfficeMate.BusinessLogic.UnitOfWork.Interface;

using OfficeMate.MongoDB.Interface;
using Microsoft.Extensions.Logging;
using OfficeMate.Common;
using OfficeMate.Prototype.BusinessLogic.Services.Interface;
using OfficeMate.BusinessLogic.Services;

namespace OfficeMate.BusinessLogic.UnitOfWork
{
	public class LogicUnitOfWork : ILogicUnitOfWork
	{
		private readonly IMongoDBUnitOfWork mongoDBUnitOfWork;
        private readonly ILogger<TempService> logger;
        private readonly IOptions<AppSettings> appSettings;
		private readonly ILoggerFactory loggerFactory;
		public LogicUnitOfWork(IOptions<AppSettings> appSettings, IMongoDBUnitOfWork mongoDBUnitOfWork, ILogger<TempService> logger)
		{
			this.appSettings = appSettings;
			this.mongoDBUnitOfWork = mongoDBUnitOfWork;
            this.logger = logger;
        }

        private ITempService tempService;
        public ITempService TempService
        {
            get { return tempService ?? (tempService = new TempService(appSettings, mongoDBUnitOfWork, logger)); }
            set { tempService = value; }
        }
    }
}
