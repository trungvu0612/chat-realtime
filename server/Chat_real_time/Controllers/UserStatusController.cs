using Domain.Interfaces;

namespace Chat_real_time.Controllers
{
    public class UserStatusController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserStatusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
