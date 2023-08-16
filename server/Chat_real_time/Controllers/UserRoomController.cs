using Domain.Interfaces;

namespace Chat_real_time.Controllers
{
    public class UserRoomController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
