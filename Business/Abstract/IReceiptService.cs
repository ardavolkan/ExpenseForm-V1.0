using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReceiptService
    {
        IResult Add(Receipt receipt);
        IDataResult<List<Receipt>> GetAll();
        IResult Delete(string id);
        IResult Update(Receipt receipt);
        IDataResult<Receipt> GetById(string Id);
        IDataResult<Receipt> GetByName(string Name);
        IDataResult<ReceiptCountDto> GetByReceiptCount();

    }
}
