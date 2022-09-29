using Entities.Dto;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contracts
{
    public interface IAddressBookService
    {
        void AddBand(User_Details user);
        Task<List<UserDto>> GetAllAddress();
        Task<UserDto> GetAddressByIdAsync(int AddressId);
        ActionResult<RefSetDto> AddRefSet(RefSetDto refsetdto);
        int CountRecords();
        Task<RefTermDto> AddRefTerm(RefTermDto reftermdto);

        Task DeleteAddress(Guid Id);

        bool Save();
    }
}
