namespace DVLD.Application.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public int AuthUserId { get; set; }
        public int PersonId { get; set; }
        public string? Role { get; set; }
        public bool IsActive { get; set; }
    }
}