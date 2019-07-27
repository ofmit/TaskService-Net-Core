using System;
using OfficeMate.MongoDB.Interface;
using OfficeMate.MongoDB.Models;
using Microsoft.Extensions.Options;
using OfficeMate.MongoDB.Repositories;

namespace OfficeMate.MongoDB
{
    public class MongoDBUnitOfWork : IMongoDBUnitOfWork, IDisposable
    {
        private readonly DatabaseContext _mongoDBContext;

        #region Log Document
        private IMongoDBRepository<LogRT> _logRTRepository;
        private IMongoDBRepository<LogRTV> _logRTVRepository;
        private IMongoDBRepository<LogRD> _logRDRepository;
        private IMongoDBRepository<LogGR> _logGRRepository;
        private IMongoDBRepository<LogDL> _logDLRepository;
        private IMongoDBRepository<LogSSR> _logSSRRepository;
        private IMongoDBRepository<LogSR> _logSRRepository;
        private IMongoDBRepository<LogPW> _logPWRepository;
        private IMongoDBRepository<LogWT> _logWTRepository;
        private IMongoDBRepository<LogSI> _logSIRepository;
        private IMongoDBRepository<LogDR> _logDRRepository;
        private IMongoDBRepository<LogRU> _logRURepository;
        private IMongoDBRepository<LogTD> _logTDRepository;
        private IMongoDBRepository<LogAQ> _logAQRepository;
        private IMongoDBRepository<LogCN> _logCNRepository;
        private IMongoDBRepository<LogSSO> _logSSORepository;
        private IMongoDBRepository<LogSPW> _logSPWRepository;
        private IMongoDBRepository<LogPIC> _logPICRepository;
        private IMongoDBRepository<LogIC> _logICRepository;
        private IMongoDBRepository<LogPSI> _logPSIRepository;
        private IMongoDBRepository<LogTR> _logTRRepository;
        private IMongoDBRepository<LogSTR> _logSTRRepository;
        private IMongoDBRepository<LogPTS> _logPTSRepository;
        private IMongoDBRepository<LogSTS> _logSTSRepository;
        private IMongoDBRepository<LogTS> _logTSRepository;
        private IMongoDBRepository<LogPTR> _logPTRRepository;
        private IMongoDBRepository<LogPRU> _logPRURepository;
        private IMongoDBRepository<LogSRU> _logSRURepository;
        private IMongoDBRepository<LogPPR> _logPPRRepository;
        private IMongoDBRepository<LogPR> _logPRRepository;
        private IMongoDBRepository<LogLT> _logLTRepository;
        private IMongoDBRepository<LogPLT> _logPLTRepository;

        #endregion

        #region Temp Document
        private IMongoDBRepository<TempRT> _tempRTRepository;
        private IMongoDBRepository<TempRTV> _tempRTVRepository;
        private IMongoDBRepository<TempGR> _tempGRRepository;
        private IMongoDBRepository<TempRD> _tempRDRepository;
        private IMongoDBRepository<TempSR> _tempSRRepository;
        private IMongoDBRepository<TempSSR> _tempSSRRepository;
        private IMongoDBRepository<TempDL> _tempDLRepository;
        private IMongoDBRepository<TempDR> _tempDRRepository;
        private IMongoDBRepository<TempPW> _tempPWRepository;
        private IMongoDBRepository<TempRU> _tempRURepository;
        private IMongoDBRepository<TempWT> _tempWTRepository;
        private IMongoDBRepository<TempCN> _tempCNRepository;
        private IMongoDBRepository<TempSI> _tempSIRepository;
        private IMongoDBRepository<TempSSO> _tempSSORepository;
        private IMongoDBRepository<TempTD> _tempTDRepository;
        private IMongoDBRepository<TempPIC> _tempPICRepository;
        private IMongoDBRepository<TempIC> _tempICRepository;
        private IMongoDBRepository<TempPSI> _tempPSIRepository;
        private IMongoDBRepository<TempPTS> _tempPTSRepository;
        private IMongoDBRepository<TempPRU> _tempPRURepository;
        private IMongoDBRepository<TempSRU> _tempSRURepository;
        private IMongoDBRepository<TempPTR> _tempPTRRepository;
        private IMongoDBRepository<TempPPR> _tempPPRRepository;
        private IMongoDBRepository<TempPR> _tempPRRepository;
        #endregion

        public MongoDBUnitOfWork(IOptions<MongoDBOptions> mongoDBSetting)
        {
            _mongoDBContext = new DatabaseContext(mongoDBSetting.Value.ConnectionString, mongoDBSetting.Value.DatabaseName, mongoDBSetting.Value.IsSSL);
        }

        public void Dispose()
        {

        }

        #region Log Repository
        public IMongoDBRepository<LogRT> LogRTRepository
        {
            get { return _logRTRepository ?? (_logRTRepository = new MongoDBRepository<LogRT>(_mongoDBContext)); }
            set { _logRTRepository = value; }
        }

        public IMongoDBRepository<LogRTV> LogRTVRepository
        {
            get { return _logRTVRepository ?? (_logRTVRepository = new MongoDBRepository<LogRTV>(_mongoDBContext)); }
            set { _logRTVRepository = value; }
        }

        public IMongoDBRepository<LogRD> LogRDRepository
        {
            get { return _logRDRepository ?? (_logRDRepository = new MongoDBRepository<LogRD>(_mongoDBContext)); }
            set { _logRDRepository = value; }
        }

        public IMongoDBRepository<LogGR> LogGRRepository
        {
            get { return _logGRRepository ?? (_logGRRepository = new MongoDBRepository<LogGR>(_mongoDBContext)); }
            set { _logGRRepository = value; }
        }

        public IMongoDBRepository<LogDL> LogDLRepository
        {
            get { return _logDLRepository ?? (_logDLRepository = new MongoDBRepository<LogDL>(_mongoDBContext)); }
            set { _logDLRepository = value; }
        }

        public IMongoDBRepository<LogSSR> LogSSRRepository
        {
            get { return _logSSRRepository ?? (_logSSRRepository = new MongoDBRepository<LogSSR>(_mongoDBContext)); }
            set { _logSSRRepository = value; }
        }

        public IMongoDBRepository<LogSR> LogSRRepository
        {
            get { return _logSRRepository ?? (_logSRRepository = new MongoDBRepository<LogSR>(_mongoDBContext)); }
            set { _logSRRepository = value; }
        }

        public IMongoDBRepository<LogPW> LogPWRepository
        {
            get { return _logPWRepository ?? (_logPWRepository = new MongoDBRepository<LogPW>(_mongoDBContext)); }
            set { _logPWRepository = value; }
        }

        public IMongoDBRepository<LogWT> LogWTRepository
        {
            get { return _logWTRepository ?? (_logWTRepository = new MongoDBRepository<LogWT>(_mongoDBContext)); }
            set { _logWTRepository = value; }
        }

        public IMongoDBRepository<LogSI> LogSIRepository
        {
            get { return _logSIRepository ?? (_logSIRepository = new MongoDBRepository<LogSI>(_mongoDBContext)); }
            set { _logSIRepository = value; }
        }

        public IMongoDBRepository<LogDR> LogDRRepository
        {
            get { return _logDRRepository ?? (_logDRRepository = new MongoDBRepository<LogDR>(_mongoDBContext)); }
            set { _logDRRepository = value; }
        }

        public IMongoDBRepository<LogRU> LogRURepository
        {
            get { return _logRURepository ?? (_logRURepository = new MongoDBRepository<LogRU>(_mongoDBContext)); }
            set { _logRURepository = value; }
        }

        public IMongoDBRepository<LogTD> LogTDRepository
        {
            get { return _logTDRepository ?? (_logTDRepository = new MongoDBRepository<LogTD>(_mongoDBContext)); }
            set { _logTDRepository = value; }
        }

        public IMongoDBRepository<LogAQ> LogAQRepository
        {
            get { return _logAQRepository ?? (_logAQRepository = new MongoDBRepository<LogAQ>(_mongoDBContext)); }
            set { _logAQRepository = value; }
        }

        public IMongoDBRepository<LogCN> LogCNRepository
        {
            get { return _logCNRepository ?? (_logCNRepository = new MongoDBRepository<LogCN>(_mongoDBContext)); }
            set { _logCNRepository = value; }
        }

        public IMongoDBRepository<LogSSO> LogSSORepository
        {
            get { return _logSSORepository ?? (_logSSORepository = new MongoDBRepository<LogSSO>(_mongoDBContext)); }
            set { _logSSORepository = value; }
        }

        public IMongoDBRepository<LogPIC> LogPICRepository
        {
            get { return _logPICRepository ?? (_logPICRepository = new MongoDBRepository<LogPIC>(_mongoDBContext)); }
            set { _logPICRepository = value; }
        }

        public IMongoDBRepository<LogIC> LogICRepository
        {
            get { return _logICRepository ?? (_logICRepository = new MongoDBRepository<LogIC>(_mongoDBContext)); }
            set { _logICRepository = value; }
        }

        public IMongoDBRepository<LogPSI> LogPSIRepository
        {
            get { return _logPSIRepository ?? (_logPSIRepository = new MongoDBRepository<LogPSI>(_mongoDBContext)); }
            set { _logPSIRepository = value; }
        }

        public IMongoDBRepository<LogTR> LogTRRepository
        {
            get { return _logTRRepository ?? (_logTRRepository = new MongoDBRepository<LogTR>(_mongoDBContext)); }
            set { _logTRRepository = value; }
        }

        public IMongoDBRepository<LogSTR> LogSTRRepository
        {
            get { return _logSTRRepository ?? (_logSTRRepository = new MongoDBRepository<LogSTR>(_mongoDBContext)); }
            set { _logSTRRepository = value; }
        }

        public IMongoDBRepository<LogPTS> LogPTSRepository
        {
            get { return _logPTSRepository ?? (_logPTSRepository = new MongoDBRepository<LogPTS>(_mongoDBContext)); }
            set { _logPTSRepository = value; }
        }

        public IMongoDBRepository<LogSTS> LogSTSRepository
        {
            get { return _logSTSRepository ?? (_logSTSRepository = new MongoDBRepository<LogSTS>(_mongoDBContext)); }
            set { _logSTSRepository = value; }
        }

        public IMongoDBRepository<LogTS> LogTSRepository
        {
            get { return _logTSRepository ?? (_logTSRepository = new MongoDBRepository<LogTS>(_mongoDBContext)); }
            set { _logTSRepository = value; }
        }

        public IMongoDBRepository<LogPTR> LogPTRRepository
        {
            get { return _logPTRRepository ?? (_logPTRRepository = new MongoDBRepository<LogPTR>(_mongoDBContext)); }
            set { _logPTRRepository = value; }
        }

        public IMongoDBRepository<LogPRU> LogPRURepository
        {
            get { return _logPRURepository ?? (_logPRURepository = new MongoDBRepository<LogPRU>(_mongoDBContext)); }
            set { _logPRURepository = value; }
        }

        public IMongoDBRepository<LogSRU> LogSRURepository
        {
            get { return _logSRURepository ?? (_logSRURepository = new MongoDBRepository<LogSRU>(_mongoDBContext)); }
            set { _logSRURepository = value; }
        }
        public IMongoDBRepository<LogPPR> LogPPRRepository
        {
            get { return _logPPRRepository ?? (_logPPRRepository = new MongoDBRepository<LogPPR>(_mongoDBContext)); }
            set { _logPPRRepository = value; }
        }
        public IMongoDBRepository<LogPR> LogPRRepository
        {
            get { return _logPRRepository ?? (_logPRRepository = new MongoDBRepository<LogPR>(_mongoDBContext)); }
            set { _logPRRepository = value; }
        }

        public IMongoDBRepository<LogLT> LogLTRepository
        {
            get { return _logLTRepository ?? (_logLTRepository = new MongoDBRepository<LogLT>(_mongoDBContext)); }
            set { _logLTRepository = value; }
        }

        public IMongoDBRepository<LogPLT> LogPLTRepository
        {
            get { return _logPLTRepository ?? (_logPLTRepository = new MongoDBRepository<LogPLT>(_mongoDBContext)); }
            set { _logPLTRepository = value; }
        }
        #endregion

        #region Temp Repository
        public IMongoDBRepository<TempRT> TempRTRepository
        {
            get { return _tempRTRepository ?? (_tempRTRepository = new MongoDBRepository<TempRT>(_mongoDBContext)); }
            set { _tempRTRepository = value; }
        }
        public IMongoDBRepository<TempRTV> TempRTVRepository
        {
            get { return _tempRTVRepository ?? (_tempRTVRepository = new MongoDBRepository<TempRTV>(_mongoDBContext)); }
            set { _tempRTVRepository = value; }
        }

        public IMongoDBRepository<TempGR> TempGRRepository
        {
            get { return _tempGRRepository ?? (_tempGRRepository = new MongoDBRepository<TempGR>(_mongoDBContext)); }
            set { _tempGRRepository = value; }
        }

        public IMongoDBRepository<TempRD> TempRDRepository
        {
            get { return _tempRDRepository ?? (_tempRDRepository = new MongoDBRepository<TempRD>(_mongoDBContext)); }
            set { _tempRDRepository = value; }
        }

        public IMongoDBRepository<TempSR> TempSRRepository
        {
            get { return _tempSRRepository ?? (_tempSRRepository = new MongoDBRepository<TempSR>(_mongoDBContext)); }
            set { _tempSRRepository = value; }
        }

        public IMongoDBRepository<TempSSR> TempSSRRepository
        {
            get { return _tempSSRRepository ?? (_tempSSRRepository = new MongoDBRepository<TempSSR>(_mongoDBContext)); }
            set { _tempSSRRepository = value; }
        }

        public IMongoDBRepository<TempDL> TempDLRepository
        {
            get { return _tempDLRepository ?? (_tempDLRepository = new MongoDBRepository<TempDL>(_mongoDBContext)); }
            set { _tempDLRepository = value; }
        }

        public IMongoDBRepository<TempDR> TempDRRepository
        {
            get { return _tempDRRepository ?? (_tempDRRepository = new MongoDBRepository<TempDR>(_mongoDBContext)); }
            set { _tempDRRepository = value; }
        }

        public IMongoDBRepository<TempPW> TempPWRepository
        {
            get { return _tempPWRepository ?? (_tempPWRepository = new MongoDBRepository<TempPW>(_mongoDBContext)); }
            set { _tempPWRepository = value; }
        }

        public IMongoDBRepository<TempRU> TempRURepository
        {
            get { return _tempRURepository ?? (_tempRURepository = new MongoDBRepository<TempRU>(_mongoDBContext)); }
            set { _tempRURepository = value; }
        }

        public IMongoDBRepository<LogSPW> LogSPWRepository
        {
            get { return _logSPWRepository ?? (_logSPWRepository = new MongoDBRepository<LogSPW>(_mongoDBContext)); }
            set { _logSPWRepository = value; }
        }

        public IMongoDBRepository<TempWT> TempWTRepository
        {
            get { return _tempWTRepository ?? (_tempWTRepository = new MongoDBRepository<TempWT>(_mongoDBContext)); }
            set { _tempWTRepository = value; }
        }

        public IMongoDBRepository<TempCN> TempCNRepository
        {
            get { return _tempCNRepository ?? (_tempCNRepository = new MongoDBRepository<TempCN>(_mongoDBContext)); }
            set { _tempCNRepository = value; }
        }

        public IMongoDBRepository<TempSI> TempSIRepository
        {
            get { return _tempSIRepository ?? (_tempSIRepository = new MongoDBRepository<TempSI>(_mongoDBContext)); }
            set { _tempSIRepository = value; }
        }

        public IMongoDBRepository<TempSSO> TempSSORepository
        {
            get { return _tempSSORepository ?? (_tempSSORepository = new MongoDBRepository<TempSSO>(_mongoDBContext)); }
            set { _tempSSORepository = value; }
        }

        public IMongoDBRepository<TempTD> TempTDRepository
        {
            get { return _tempTDRepository ?? (_tempTDRepository = new MongoDBRepository<TempTD>(_mongoDBContext)); }
            set { _tempTDRepository = value; }
        }

        public IMongoDBRepository<TempPIC> TempPICRepository
        {
            get { return _tempPICRepository ?? (_tempPICRepository = new MongoDBRepository<TempPIC>(_mongoDBContext)); }
            set { _tempPICRepository = value; }
        }

        public IMongoDBRepository<TempIC> TempICRepository
        {
            get { return _tempICRepository ?? (_tempICRepository = new MongoDBRepository<TempIC>(_mongoDBContext)); }
            set { _tempICRepository = value; }
        }

        public IMongoDBRepository<TempPSI> TempPSIRepository
        {
            get { return _tempPSIRepository ?? (_tempPSIRepository = new MongoDBRepository<TempPSI>(_mongoDBContext)); }
            set { _tempPSIRepository = value; }
        }

        public IMongoDBRepository<TempPTS> TempPTSRepository
        {
            get { return _tempPTSRepository ?? (_tempPTSRepository = new MongoDBRepository<TempPTS>(_mongoDBContext)); }
            set { _tempPTSRepository = value; }
        }

        public IMongoDBRepository<TempPRU> TempPRURepository
        {
            get { return _tempPRURepository ?? (_tempPRURepository = new MongoDBRepository<TempPRU>(_mongoDBContext)); }
            set { _tempPRURepository = value; }
        }

        public IMongoDBRepository<TempSRU> TempSRURepository
        {
            get { return _tempSRURepository ?? (_tempSRURepository = new MongoDBRepository<TempSRU>(_mongoDBContext)); }
            set { _tempSRURepository = value; }
        }
        public IMongoDBRepository<TempPTR> TempPTRRepository
        {
            get { return _tempPTRRepository ?? (_tempPTRRepository = new MongoDBRepository<TempPTR>(_mongoDBContext)); }
            set { _tempPTRRepository = value; }
        }
        public IMongoDBRepository<TempPPR> TempPPRRepository
        {
            get { return _tempPPRRepository ?? (_tempPPRRepository = new MongoDBRepository<TempPPR>(_mongoDBContext)); }
            set { _tempPPRRepository = value; }
        }
        public IMongoDBRepository<TempPR> TempPRRepository
        {
            get { return _tempPRRepository ?? (_tempPRRepository = new MongoDBRepository<TempPR>(_mongoDBContext)); }
            set { _tempPRRepository = value; }
        }
        #endregion

    }
}



