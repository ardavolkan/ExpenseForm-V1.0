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
    public class MongoDB_ReceiptDal : MongoDB_RepositoryBase<Receipt, MongoDB_Context<Receipt, MongoDB_ReceiptCollection>>, IReceiptDal
    {
        public ReceiptCountDto GetCount()
        {
            var count = new ReceiptCountDto();
            var receipt = base.GetAll();
            count.Count = receipt.Count;
            return count;
        }
    }
}
