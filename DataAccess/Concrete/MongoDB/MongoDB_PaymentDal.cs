using Core.DataAccess.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_PaymentDal : MongoDB_RepositoryBase<Payment, MongoDB_Context<Payment, MongoDB_PaymentCollection>>, IPaymentDal
    {
    }
}
