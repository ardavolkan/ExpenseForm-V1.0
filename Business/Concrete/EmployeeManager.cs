using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.EmployeeAdded);
        }

        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Delete(string id)
        {
            _employeeDal.Delete(id);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(),Messages.EmployeeListed);
        }

        public IDataResult<Employee> GetByDepartment(string department)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(u => u.EmployeeDepartment == department));
        }

        public IDataResult<Employee> GetById(string Id)
        {
            return new SuccessDataResult<Employee> (_employeeDal.Get(u => u.Id == Id));
        }

        public IDataResult<Employee> GetByName(string Firstname)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(u => u.EmployeeFirstName == Firstname));
        }

        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
    }
}
