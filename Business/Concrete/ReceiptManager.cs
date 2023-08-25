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
    public class ReceiptManager : IReceiptService
    {

        private readonly IReceiptDal _receiptDal;
        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }
        
        [ValidationAspect(typeof(ReceiptValidator))]
        public IResult Add(Receipt receipt)
        {
            _receiptDal.Add(receipt);
            return new SuccessResult(Messages.ReceiptAdded);
        }

        [ValidationAspect(typeof(ReceiptValidator))]
        public IResult Delete(Receipt receipt)
        {
            _receiptDal.Delete(receipt);
            return new SuccessResult(Messages.ReceiptDeleted);

        }

        public IDataResult<List<Receipt>> GetAll()
        {

            return new SuccessDataResult<List<Receipt>>(Messages.ReceiptListed);
        }

        public Receipt GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public Receipt GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(ReceiptValidator))]
        public IResult Update(Receipt receipt)
        {
            _receiptDal.Update(receipt);
            return new SuccessResult(Messages.ReceiptUpdated);
        }

        IDataResult<Receipt> IReceiptService.GetById(string Id)
        {
            throw new NotImplementedException();
        }

        IDataResult<Receipt> IReceiptService.GetByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
