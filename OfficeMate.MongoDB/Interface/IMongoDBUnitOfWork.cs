using OfficeMate.MongoDB.Interface;
using OfficeMate.MongoDB.Models;

namespace OfficeMate.MongoDB.Interface
{
    public interface IMongoDBUnitOfWork
    {
        IMongoDBRepository<LogRT> LogRTRepository { get; set; }
        IMongoDBRepository<LogRTV> LogRTVRepository { get; set; }
        IMongoDBRepository<LogRD> LogRDRepository { get; set; }
        IMongoDBRepository<LogGR> LogGRRepository { get; set; }
        IMongoDBRepository<LogDL> LogDLRepository { get; set; }
        IMongoDBRepository<LogSSR> LogSSRRepository { get; set; }
        IMongoDBRepository<LogSR> LogSRRepository { get; set; }
        IMongoDBRepository<LogPW> LogPWRepository { get; set; }
        IMongoDBRepository<LogWT> LogWTRepository { get; set; }
        IMongoDBRepository<LogSI> LogSIRepository { get; set; }
        IMongoDBRepository<LogDR> LogDRRepository { get; set; }
		IMongoDBRepository<LogRU> LogRURepository { get; set; }
        IMongoDBRepository<LogTD> LogTDRepository { get; set; }
        IMongoDBRepository<LogAQ> LogAQRepository { get; set; }
        IMongoDBRepository<LogCN> LogCNRepository { get; set; }
        IMongoDBRepository<LogSSO> LogSSORepository { get; set; }
        IMongoDBRepository<LogSPW> LogSPWRepository { get; set; }
        IMongoDBRepository<LogPIC> LogPICRepository { get; set; }
        IMongoDBRepository<LogIC> LogICRepository { get; set; }
        IMongoDBRepository<LogPSI> LogPSIRepository { get; set; }
        IMongoDBRepository<LogTR> LogTRRepository { get; set; }
        IMongoDBRepository<LogSTR> LogSTRRepository { get; set; }
        IMongoDBRepository<LogPTS> LogPTSRepository { get; set; }
        IMongoDBRepository<LogSTS> LogSTSRepository { get; set; }
        IMongoDBRepository<LogTS> LogTSRepository { get; set; }
        IMongoDBRepository<LogPTR> LogPTRRepository { get; set; }
        IMongoDBRepository<LogPRU> LogPRURepository { get; set; }
        IMongoDBRepository<LogSRU> LogSRURepository { get; set; }
        IMongoDBRepository<LogPPR> LogPPRRepository { get; set; }
        IMongoDBRepository<LogPR> LogPRRepository { get; set; }
        IMongoDBRepository<LogLT> LogLTRepository { get; set; }
        IMongoDBRepository<LogPLT> LogPLTRepository { get; set; }

        IMongoDBRepository<TempRT> TempRTRepository { get; set; }
        IMongoDBRepository<TempRTV> TempRTVRepository { get; set; }
        IMongoDBRepository<TempGR> TempGRRepository { get; set; }
        IMongoDBRepository<TempRD> TempRDRepository { get; set; }
        IMongoDBRepository<TempSR> TempSRRepository { get; set; }
        IMongoDBRepository<TempSSR> TempSSRRepository { get; set; }
        IMongoDBRepository<TempDL> TempDLRepository { get; set; }
        IMongoDBRepository<TempDR> TempDRRepository { get; set; }
        IMongoDBRepository<TempPW> TempPWRepository { get; set; }
        IMongoDBRepository<TempRU> TempRURepository { get; set; }
        IMongoDBRepository<TempWT> TempWTRepository { get; set; }
        IMongoDBRepository<TempCN> TempCNRepository { get; set; }
        IMongoDBRepository<TempSI> TempSIRepository { get; set; }
        IMongoDBRepository<TempSSO> TempSSORepository { get; set; }
        IMongoDBRepository<TempTD> TempTDRepository { get; set; }
        IMongoDBRepository<TempPIC> TempPICRepository { get; set; }
        IMongoDBRepository<TempIC> TempICRepository { get; set; }
        IMongoDBRepository<TempPSI> TempPSIRepository { get; set; }
        IMongoDBRepository<TempPTS> TempPTSRepository { get; set; }
        IMongoDBRepository<TempPRU> TempPRURepository { get; set; }
        IMongoDBRepository<TempSRU> TempSRURepository { get; set; }
        IMongoDBRepository<TempPTR> TempPTRRepository { get; set; }
        IMongoDBRepository<TempPPR> TempPPRRepository { get; set; }
        IMongoDBRepository<TempPR> TempPRRepository { get; set; }
    }
} 
