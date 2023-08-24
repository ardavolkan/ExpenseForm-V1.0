using Core.DataAccess.MongoDB;
using Core.Entities;
using Core.Utilities.IoC;
using Core.Utilities.ServiceConnectionHelpers;
using DataAccess.Concrete.Databases;
using DataAccess.Concrete.Databases.MongoDB.Collections;
using DataAccess.Concrete.Databases.MongoDB.Utilities.ConnectionResolvers;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Text;
using System.Threading;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_Context<TEntity, PredefinedCollection> : IDisposable, IMongoDB_Context<TEntity>
        where PredefinedCollection : class, IMongDB_Collection, new()
        where TEntity : class, IEntity, new()
    {
        public MongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<TEntity> collection { get; set; }
        private PredefinedCollection predefinedCollection = new PredefinedCollection();
        private readonly IConfiguration configuration = ServiceTool.ServiceProvider.GetService<IConfiguration>();
        private readonly CompressionSetting databaseConnectionSettings;
        private readonly EPSResultant epsResultant;
        private readonly DeduplicationStandarts deduplicationStandarts;
        private readonly string Statistics;

        public MongoDB_Context()
        {
            databaseConnectionSettings = configuration.GetSection(nameof(CompressionSetting)).Get<CompressionSetting>();
            epsResultant = configuration.GetSection(nameof(EPSResultant)).Get<EPSResultant>();
            deduplicationStandarts = configuration.GetSection(nameof(DeduplicationStandarts)).Get<DeduplicationStandarts>();
            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            Statistics = encoding.GetString(deduplicationStandarts.Statics);
            GetMongoDBCollection();
        }
        public IMongoCollection<TEntity> GetMongoDBCollection()
        {
        tryAgain:
            try
            {
                var database_ConnectionHelper = ServiceTool.Host.Services.GetService<IDatabase_ConnectionHelper>();
                var result = MongoDBConnectionHelper.CheckDatabaseConnection(Statistics, epsResultant.Stability, databaseConnectionSettings.CompressStandarts, databaseConnectionSettings.Database);
                //var result = database_ConnectionHelper.CheckDatabaseConnection();
                if (result.Success)
                {
                    client = new MongoClient(result.Data.HostName);
                    database = client.GetDatabase(result.Data.Database);
                    collection = database.GetCollection<TEntity>(predefinedCollection.CollectionName);
                    return collection;
                }
                return null;
            }
            catch (System.Exception)
            {

                Thread.Sleep(15000);
                goto tryAgain;

            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
