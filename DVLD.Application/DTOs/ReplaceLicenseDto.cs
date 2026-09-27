using DVLD.Domain.Enums;

namespace DVLD.Application.DTOs
{
    public class ReplaceLicenseDto
    {
        public int LicenseID { get; set; }
        public IssueReasonEnum IssueReason { get; set; }
    }
}