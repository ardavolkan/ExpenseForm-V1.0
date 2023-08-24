using DataAccess.Concrete.Databases.MongoDB.Collections;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_EmployeeCollection : IMongDB_Collection
    {
        public string CollectionName { get; set; }

        public MongoDB_EmployeeCollection()
        {
            CollectionName = "Employees";
        }
    }
}
