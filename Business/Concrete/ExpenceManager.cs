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
        public IResult Delete(string  id)
        {
            _expenceDal.Delete(id);
            return new SuccessResult(Messages.ExpenceDeleted);
        }

        public IDataResult<List<Expence>> GetAll()
        {
            return new SuccessDataResult<List<Expence>>(_expenceDal.GetAll(), Messages.ExpenceListed);
        }

        public IDataResult<Expence> GetByAmount(string amount)
        {
            return new SuccessDataResult<Expence>(_expenceDal.Get(u => u.Amount == amount));
        }

        public IDataResult<Expence> GetByDate(string date)
        {
            return new SuccessDataResult<Expence>(_expenceDal.Get(u => u.Date == date));
        }

        public IDataResult<Expence> GetById(string Id)
        {
            return new SuccessDataResult<Expence>(_expenceDal.Get(u => u.Id == Id));
        }

        [ValidationAspect(typeof(ExpenceValidator))]
        public IResult Update(Expence expence)
        {
            _expenceDal.Update(expence);
            return new SuccessResult(Messages.ExpenceUpdated);
        }
    }
}
