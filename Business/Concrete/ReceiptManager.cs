using Business.Abstract;
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
        //Enjecte et (IReceiptDal)

        private readonly IReceiptDal _receiptDal;
        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }

        public IResult Add(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Receipt>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Receipt GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Receipt GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }
}
