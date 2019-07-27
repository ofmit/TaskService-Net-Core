using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OfficeMate.Prototype.BusinessLogic.Services.Interface;
using OfficeMate.MongoDB.Interface;
using Microsoft.Extensions.Options;
using OfficeMate.Common;

namespace OfficeMate.BusinessLogic.Services
{
    public class TempService : ITempService
    {
        private readonly ILogger _logger;
        private readonly IOptions<AppSettings> appSettings;
        private readonly IMongoDBUnitOfWork mongoDBUnitOfWork;

        public TempService(IOptions<AppSettings> appSettings, IMongoDBUnitOfWork mongoDBUnitOfWork, ILogger<TempService> logger)
        {
            this.appSettings = appSettings;
            this.mongoDBUnitOfWork = mongoDBUnitOfWork;
            _logger = logger;
		}

        public void DeleteAllAsync()
        {
            // mongoDBUnitOfWork.TempRTRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempRTVRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempGRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempRDRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempSRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempSSRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempDLRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempDRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPWRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempRURepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempWTRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempCNRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempSIRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempSSORepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempTDRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPICRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempICRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPSIRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPTSRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPRURepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempSRURepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPTRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPPRRepository.DeleteAllAsync();
            // mongoDBUnitOfWork.TempPRRepository.DeleteAllAsync();
        }
	}
}
