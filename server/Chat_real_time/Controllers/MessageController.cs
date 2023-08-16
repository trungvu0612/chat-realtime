using Domain.Interfaces;

namespace Chat_real_time.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public MessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
