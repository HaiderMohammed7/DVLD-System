using DVLD.Application.Enums;

namespace DVLD.Application.DTOs
{
    public class UserDto
    {
        public int UserID { get; set; }
        public int AuthUserId { get; set; }
        public int PersonID { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
    }
}