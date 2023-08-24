using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IReceiptService
    {
        IResult Add(Receipt receipt);
        IDataResult <List<Receipt>> GetAll();
        IResult Delete(Receipt receipt);
        IResult Update(Receipt receipt);
        IDataResult<Receipt> GetById(int Id);
      IDataResult<Receipt> GetByName(string Name);

    }
}
