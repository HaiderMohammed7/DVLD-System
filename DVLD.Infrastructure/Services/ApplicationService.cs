using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class ApplicationService
    {
        private readonly DVLDApiClient _http;

        public ApplicationService(DVLDApiClient http)
        {
            _http = http;
        }
    }
}