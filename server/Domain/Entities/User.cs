namespace Domain.Entities
{
    public class User
    {
        public User()
        {
            UserRooms = new List<UserRoom>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public IList<UserRoom> UserRooms { get; set; }
    }
}
