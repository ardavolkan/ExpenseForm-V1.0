using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IResult Add(Employee employee0);  //+
        IResult Delete(string id); //+
        IResult Update(Employee employee0); //+
        IDataResult<List<Employee>> GetAll(); //+
        IDataResult<Employee> GetById(string Id);  //+
        IDataResult<Employee> GetByName(string name); //+
        IDataResult<Employee> GetByDepartment(string department);
        IDataResult<EmployeeCountDto> GetByEmployeeCount();

    }
}
