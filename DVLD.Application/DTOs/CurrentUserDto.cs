namespace DVLD.Application.DTOs
{
    public class CurrentUserDto
    {
        public int UserId { get; set; }
        public int AuthUserId { get; set; }
        public int PersonId { get; set; }
        public string? Role { get; set; }
    }
}