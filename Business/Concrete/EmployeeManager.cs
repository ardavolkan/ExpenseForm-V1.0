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
        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(Messages.EmployeeListed);
        }

        public Employee GetByDepartment(string department)
        {
            return _employeeDal.Get(u => u.EmployeeDepartment == department);
        }

        public Employee GetById(int Id)
        {
            return _employeeDal.Get(u => u.EmployeeId == Id);
        }

        public Employee GetByName(string name)
        {
            return _employeeDal.Get(u => u.EmployeeFirstName == name);
        }

        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
    }
}
