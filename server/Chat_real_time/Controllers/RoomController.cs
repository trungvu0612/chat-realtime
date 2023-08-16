using Domain.Interfaces;

namespace Chat_real_time.Controllers
{
    public class RoomController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
