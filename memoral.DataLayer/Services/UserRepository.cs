using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memoral.DataLayer.Repositories;
using System.Data.Entity;


namespace memoral.DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        MemoralDBEntities db;

        public UserRepository(MemoralDBEntities db)
        {
            this.db = db;
        }
        public bool DeleteUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Users> GetAllManager()
        {
            return db.Users.Where(p => p.degree == 1).ToList();
        }

        public List<Users> GetAllSeller()
        {
            var resault = GetAllUsers();
            resault.RemoveAll(p => p.degree == 1|| p.degree==0);
            return resault;
        }

        public List<Users> GetAllUsers()
        {
            return db.Users.ToList(); 
        }

        public Users GetUserbyId(int userId)
        {
            return db.Users.Find(userId);
        }

        public List<Users> GetUserbyUsername(string username)
        {

            return db.Users.Where(p => p.username == username).ToList();
        }

  

        public bool InsertUser(Users user)
        {
            try
            {
                db.Users.Add(user);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdateUser(Users user)
        {

            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
