namespace DVLD.Application.DTOs
{
    public class AppointmentsListDto
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsLocked { get; set; }
    }
}