using Domain.Entities;
using Domain.Interfaces;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserRoomRepository : GenericRepository<UserRoom>, IUserRoomRepository
    {
        public UserRoomRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
