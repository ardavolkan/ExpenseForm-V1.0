﻿using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

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

            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(), Messages.ReceiptListed);
        }

        [ValidationAspect(typeof(ReceiptValidator))]
        public IResult Update(Receipt receipt)
        {
            _receiptDal.Update(receipt);
            return new SuccessResult(Messages.ReceiptUpdated);
        }

        IDataResult<Receipt> IReceiptService.GetById(string Id)
        {
            return (IDataResult<Receipt>)_receiptDal.Get(u => u.ReceiptId == Id);
        }

        IDataResult<Receipt> IReceiptService.GetByName(string Name)
        {
            return (IDataResult<Receipt>)_receiptDal.Get(u => u.EmployeeFirstName == Name);
        }


    }
}
