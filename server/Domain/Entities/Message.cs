namespace Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }

        // Tham chiếu đến phòng tương ứng
        public Room Room { get; set; }

        // Tham chiếu đến người dùng gửi tin nhắn
        public User User { get; set; }
    }
}
