using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        public clsUser? GetByID(int userID);
        public clsUser? GetByEmail(string email);
        public bool EmailExists(string email);
        public int Create(clsUser user);

        public bool Update(clsUser user);
    }
}