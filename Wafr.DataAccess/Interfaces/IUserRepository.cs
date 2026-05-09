using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        clsUser? GetByID(int userID);

        clsUser? GetByEmail(string email);

        bool EmailExists(string email);

        int Create(clsUser user);

        bool Update(clsUser user);
    }
}