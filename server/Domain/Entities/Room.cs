namespace Domain.Entities
{
    public class Room
    {
        public Room()
        {
            UsersInRoom = new List<UserRoom>();
            Messages = new List<Message>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        // Số lượng người dùng đang truy cập trong phòng
        public int UserCount { get; set; }

        // Danh sách người dùng trong phòng
        public IList<UserRoom> UsersInRoom { get; set; }

        // Danh sách tin nhắn trong phòng
        public IList<Message> Messages { get; set; }
    }
}
