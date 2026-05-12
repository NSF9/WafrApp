using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsUserRepository : IUserRepository
    {
        public clsUser? GetByID(int userID)
        {
            throw new NotImplementedException();
        }
        public clsUser? GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public bool EmailExists(string email)
        {
            throw new NotImplementedException();
        }
        public int Create(clsUser user)
        {
            throw new NotImplementedException();
        }

        public bool Update(clsUser user)
        {
            throw new NotImplementedException();
        }
    }
}