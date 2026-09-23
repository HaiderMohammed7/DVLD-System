namespace DVLD.Application.DTOs
{
    public class GetLocalDrivingLicenseApplicationInfoDto
    {
        public int ApplicationID { get; set; }
        public int? LicenseID { get; set; }

        public string LicenseClassName { get; set; } = null!;

        public int PassedTests { get; set; }
    }
}