using Domain.Entities;
using Domain.Interfaces;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(DatabaseContext context) : base(context) { }
    }
}
