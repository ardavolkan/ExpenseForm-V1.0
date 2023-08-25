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
using static MongoDB.Driver.WriteConcern;

namespace Business.Concrete
{
    public class ExpenceManager : IExpenceService
    {
        private readonly IExpenceDal _expenceDal;

        public ExpenceManager(IExpenceDal expenceDal)
        {
            _expenceDal = expenceDal;
        }

        [ValidationAspect(typeof(ExpenceValidator))]
        public IResult Add(Expence expence)
        {
            _expenceDal.Add(expence);
            return new SuccessResult(Messages.ExpenceAdded);
        }

        [ValidationAspect(typeof(ExpenceValidator))]
        public IResult Delete(Expence expence)
        {
            _expenceDal.Delete(expence);
            return new SuccessResult(Messages.ExpenceDeleted);
        }

        public IDataResult<List<Expence>> GetAll()
        {
            return new SuccessDataResult<List<Expence>>(_expenceDal.GetAll(),Messages.ExpenceListed);
        }

        public IDataResult<Expence> GetByAmount(string amount)
        {
            return (IDataResult<Expence>)_expenceDal.Get(u => u.Amount == amount);
        }

        [ValidationAspect(typeof(ExpenceValidator))]
        public IResult Update(Expence expence)
        {
            _expenceDal.Update(expence);
            return new SuccessResult(Messages.ExpenceUpdated);
        }

        IDataResult<Expence> IExpenceService.GetByDate(string date)
        {
            return (IDataResult<Expence>)_expenceDal.Get(u => u.Date == date);
        }

        IDataResult<Expence> IExpenceService.GetById(string Id)
        {
            return (IDataResult<Expence>)_expenceDal.Get(u => u.Id == Id);
        }
    }
}
