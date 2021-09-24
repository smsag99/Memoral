using memoral.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoral.DataLayer.Repositories
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        List<Users> GetAllSeller();
        List<Users> GetAllManager();
        Users GetUserbyId(int userId);
        bool InsertUser(Users user);
        bool UpdateUser(Users user);
        bool DeleteUser(Users user);
        void Save();
        List<Users> GetUserbyUsername(string username);

    }
}
