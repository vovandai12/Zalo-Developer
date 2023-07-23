using Zalo_Tool_V1.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Zalo_Tool_V1.Database.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(User account)
        {
            try
            {
                _dbContext.Users.Add(account);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

        }

        public void Delete(Guid id)
        {
            try
            {
                var delete = _dbContext.Users.FirstOrDefault(x => x._Id == id);
                if (delete != null)
                {
                    _dbContext.Users.Remove(delete);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

        }

        public void DeleteRange(List<Guid> deleteList)
        {
            try
            {
                foreach (var id in deleteList)
                {
                    var delete = _dbContext.Users.FirstOrDefault(x => x._Id == id);
                    if (delete != null)
                    {
                        _dbContext.Users.Remove(delete);
                    }
                }
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            return null;
        }

        public User GetById(Guid id)
        {
            try
            {
                return _dbContext.Users.FirstOrDefault(s => s._Id == id);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            return null;

        }

        public void Update(User account)
        {
            try
            {
                if (_dbContext.Entry(account).State == EntityState.Unchanged)
                {
                    _dbContext.SaveChanges();
                }
                _dbContext.Users.Attach(account);
                _dbContext.Entry(account).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
        }
        public void DeleteAll()
        {
            try
            {
                var accounts = _dbContext.Users;
                _dbContext.Users.RemoveRange(accounts);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

        }
    }
}
