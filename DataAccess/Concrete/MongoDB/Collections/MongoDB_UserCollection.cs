using Core.Entities.Concrete;
using DataAccess.Concrete.Databases.MongoDB.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_UserCollection : IMongDB_Collection
    {

        public string CollectionName { get; set; }

        public MongoDB_UserCollection()
        {
            CollectionName = "Users";
        }
    }
}
