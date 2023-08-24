using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReceiptService
    {
        IResult Add(Receipt receipt);
        IDataResult<List<Receipt>> GetAll();
        IResult Delete(Receipt receipt);
        IResult Update(Receipt receipt);
        Receipt GetById(string Id);

    }
}
