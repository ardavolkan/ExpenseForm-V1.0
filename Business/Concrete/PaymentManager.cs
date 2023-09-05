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

        [ValidationAspect(typeof(PaymentValidator))]
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentAdded);
        }

        [ValidationAspect(typeof(PaymentValidator))]
        public IResult Delete(string id)
        {
            _paymentDal.Delete(id);
            return new SuccessResult(Messages.PaymentDeleted);
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(), Messages.PaymentListed);
        }

        public IDataResult<Payment> GetByHistory(string history)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.History == history));
        }

        public IDataResult<Payment> GetById(string Id)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.Id == Id));
        }

        public IDataResult<Payment> GetByName(string employeeFirstName)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.EmployeeFirstName == employeeFirstName));
        }

        [ValidationAspect(typeof(PaymentValidator))]
        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult(Messages.PaymentUpdated);
        }

    }
}
