using Core.DataAccess.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_EmployeeDal : MongoDB_RepositoryBase<Employee, MongoDB_Context<Employee, MongoDB_EmployeeCollection>>, IEmployeeDal
    {
        public EmployeeCountDto GetCount()
        {
            var count = new EmployeeCountDto();
            var employee = base.GetAll();
            count.Count = employee.Count();
            return count;
        }
    }
}
