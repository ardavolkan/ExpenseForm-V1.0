using Core.DataAccess.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_PaymentDal : MongoDB_RepositoryBase<Payment, MongoDB_Context<Payment, MongoDB_PaymentCollection>>, IPaymentDal
    {
        public PaymentCountDto GetCount()
        {
            var count = new PaymentCountDto();
            var payment = base.GetAll();
            count.Count = payment.Count;
            return count;
        }

    }
}
