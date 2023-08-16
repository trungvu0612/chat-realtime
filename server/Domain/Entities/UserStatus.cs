namespace Domain.Entities
{
    public class UserStatus
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsOnline { get; set; }
        public User User { get; set; }
    }
}
