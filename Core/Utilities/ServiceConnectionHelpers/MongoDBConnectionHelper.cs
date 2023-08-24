using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;

namespace Core.Utilities.ServiceConnectionHelpers
{
    public class MongoDBConnectionHelper
    {
        public static IDataResult<DatabaseConnectionSettings> CheckDatabaseConnection(string password, byte[] passwordHash, byte[] passwordSalt, string database)
        {

            var result = HashingHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);

            if (result)
            {
                return new SuccessDataResult<DatabaseConnectionSettings>(new DatabaseConnectionSettings { HostName = $"mongodb://localhost:27017", Database = database });
            }

            return new ErrorDataResult<DatabaseConnectionSettings>();




        }
    }
}
