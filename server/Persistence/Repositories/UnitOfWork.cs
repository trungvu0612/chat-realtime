using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UnitOfWork
    {
        private DatabaseContext context;
        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
