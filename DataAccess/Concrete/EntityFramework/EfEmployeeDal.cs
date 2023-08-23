﻿using Core.DateAcsess.EntityFramrework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, NorthwindContext>, IEmployeeDal
    {
    }
}
