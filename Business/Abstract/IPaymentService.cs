using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<List<Payment>> GetAll();
        IResult Add(Payment payment);
        IResult Delete(string id);
        IResult Update(Payment payment);
        IDataResult<Payment> GetById(string Id);
        IDataResult<Payment> GetByName(string employeeFirstName);
        IDataResult<Payment> GetByHistory(string history);
        IDataResult<PaymentCountDto> GetByPaymentCount();
    }
}
