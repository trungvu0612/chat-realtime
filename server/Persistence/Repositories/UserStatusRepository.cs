using Domain.Entities;
using Domain.Interfaces;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserStatusRepository : GenericRepository<UserStatus>, IUserStatusRepository
    {
        public UserStatusRepository(DatabaseContext context) : base(context) { }
    }
}
