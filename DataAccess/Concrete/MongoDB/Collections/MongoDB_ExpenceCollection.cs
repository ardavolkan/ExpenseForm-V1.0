

using DataAccess.Concrete.Databases.MongoDB.Collections;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ExpenceCollection : IMongDB_Collection
    {
        public string CollectionName { get; set; }

        public MongoDB_ExpenceCollection()
        {
            CollectionName = "Expences";
        }
    }
}
