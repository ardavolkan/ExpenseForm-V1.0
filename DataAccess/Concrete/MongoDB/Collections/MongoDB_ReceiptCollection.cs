﻿using DataAccess.Concrete.Databases.MongoDB.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ReceiptCollection : IMongDB_Collection
    {
        public string CollectionName { get; set; }

        public MongoDB_ReceiptCollection()
        {
            CollectionName = "Receipts";
        }
    }
}
