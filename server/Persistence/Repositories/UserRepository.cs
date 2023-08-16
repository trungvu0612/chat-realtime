using Domain.Entities;
using Domain.Interfaces;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context): base(context) { }
    }
}
