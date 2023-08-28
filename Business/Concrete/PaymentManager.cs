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

        public IDataResult<Payment> GetByHistory(string history)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Payment> GetById(string Id)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.Id == Id));
        }

        public IResult Update(Payment payment)
        {
            throw new NotImplementedException();
        }

        //[ValidationAspect(typeof(PaymentValidator))]
        //public IResult Add(Payment payment)
        //{
        //    _paymentDal.Add(payment);
        //    return new SuccessResult(Messages.PaymentAdded);
        //}

        //[ValidationAspect(typeof(PaymentValidator))]
        //public IResult Delete(Payment payment)
        //{
        //    _paymentDal.Delete(payment);
        //    return new SuccessResult(Messages.PaymentDeleted);
        //}

        //public IDataResult<List<Payment>> GetAll()
        //{
        //    return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(),Messages.PaymentListed);
        //}


        //[ValidationAspect(typeof(PaymentValidator))]
        //public IResult Update(Payment payment)
        //{
        //    _paymentDal.Update(payment);
        //    return new SuccessResult(Messages.PaymentUpdated);
        //}

        //IDataResult<Payment> IPaymentService.GetByHistory(string history)
        //{
        //    return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.History == history));
        //}

        //IDataResult<Payment> GetById(string id)
        //{
        //    return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.Id == id));
        //}
    }
}
