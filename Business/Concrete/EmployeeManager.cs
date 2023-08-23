using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee0)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Employee employee0)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetByDepartment(string department)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Employee GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Employee employee0)
        {
            throw new NotImplementedException();
        }
    }
}
