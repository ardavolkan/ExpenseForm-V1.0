using Core.DataAccess.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_EmployeeDal : MongoDB_RepositoryBase<Employee, MongoDB_Context<Employee, MongoDB_EmployeeCollection>>, IEmployeeDal
    {
    }
}
