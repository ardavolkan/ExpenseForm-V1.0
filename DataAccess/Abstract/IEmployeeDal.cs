using Core.DataAccess.Databases;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        EmployeeCountDto GetCount();
    }
}
