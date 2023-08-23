using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IResult Add(Payment payment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Payment payment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Payment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Payment GetByHistory(string history)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
