using System.Linq;
using Biz.Interfaces;
using Core.Domains;
using Data;

namespace Biz.Services
{
    class UserService : IUserService
    {
        private readonly IRepository<User> _userRepo;

        public UserService()
        {
            _userRepo = new Repository<User>();
        }

        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }

        public IQueryable<User> GetAll()
        {
            return _userRepo.Table;
        }

        public User GetByEmailId(string id)
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int id)
        {
            return _userRepo.GetById(id);
        }

        public void InsertOrUpdate(User user)
        {
            if (user.Id == 0)
            {
                _userRepo.Update(user);
            }
            else
            {
                _userRepo.Insert(user);
            }
                
        }
    }
}
