﻿using Core.DataAccess.MongoDB;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_OperationClaimDal : MongoDB_RepositoryBase<OperationClaim, MongoDB_Context<OperationClaim, MongoDB_OperationClaimCollection>>, IOperationClaimDal
    {

    }
}
