using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExpenceService
    {
        IResult Add(Expence expence);
        IResult Delete(Expence expence);
        IResult Update(Expence expence);
        Expence GetByDate(string date);
        Expence GetById(string Id);
        Expence GetByAmount(string amount);
        IDataResult<List<Expence>> GetAll();
    }
}
