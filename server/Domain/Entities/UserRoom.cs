namespace Domain.Entities
{
    public class UserRoom
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }

        // Thời gian vào phòng
        public DateTime JoinedAt { get; set; }

        // Thời gian rời phòng (nếu có)
        public DateTime? LeftAt { get; set; }

        // Tham chiếu đến người dùng tương ứng
        public User User { get; set; }

        // Tham chiếu đến phòng tương ứng
        public Room Room { get; set; }
    }
}
