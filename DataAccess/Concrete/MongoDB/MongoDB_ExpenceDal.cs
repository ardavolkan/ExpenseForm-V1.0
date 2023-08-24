using Core.DataAccess.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_ExpenceDal : MongoDB_RepositoryBase<Expence, MongoDB_Context<Expence, MongoDB_ExpenceCollection>>, IExpenceDal
    {
    }
}
