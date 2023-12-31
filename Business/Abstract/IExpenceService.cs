﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExpenceService
    {
        IResult Add(Expence expence);
        IResult Delete(string id);
        IResult Update(Expence expence);
        IDataResult<Expence> GetByDate(string date);
        IDataResult<Expence> GetById(string Id);
        IDataResult<Expence> GetByAmount(string amount);
        IDataResult<List<Expence>> GetAll();
    }
}
