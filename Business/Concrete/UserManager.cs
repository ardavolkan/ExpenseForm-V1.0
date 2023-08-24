using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager
    {
        private readonly IUserDal _userdal;
        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userdal.Add(user);
        }

        public User GetByEmail(string email)
        {
            return _userdal.Get(u => u.Email == email);
        }

    }
}
