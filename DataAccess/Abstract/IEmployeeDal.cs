using Core.DataAccess.Databases;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {

    }
}
