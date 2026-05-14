using DVLD.Application.DTOs;

namespace DVLD.Application.Interfaces
{
    public interface IPeopleService
    {
        Task<PersonDto> GetMyPersonAsync();
    }
}