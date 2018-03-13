using Core.Domains;
using System.Linq;

namespace Biz.Interfaces
{
    public interface IUserService
    {

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IQueryable<User> GetAll();

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        User GetById(int id);

        User GetByEmailId(string id);

        /// <summary>
        /// Inserts or updates the model.
        /// </summary>
        /// <param name="account">The account.</param>
        void InsertOrUpdate(User user);
    }
}
