using AutoMapper;
using Contracts;
using Entities.Dto;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;

namespace Service
{
    public class AddressBookService : IAddressBookService
    {
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;
        

        public AddressBookService(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /* public  ActionResult<RefSetDto> AddRefSet(RefSetDto refsetdto)
         {
             var result = _mapper.Map<RefSet>(refsetdto);
             var r = _mapper.Map<RefSetDto>(result);
             return r;
         }*/

        public void AddBand(User_Details user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            _context.User_Details.Add(user);
        }

        public async Task<RefTermDto> AddRefTerm(RefTermDto reftermdto)
        {
            var result = _mapper.Map<RefTerm>(reftermdto);
            var r = _mapper.Map<RefTermDto>(result);
            return r;
        }

        public async Task<List<UserDto>> GetAllAddress()
        {
            var book = await _context.User_Details.ToListAsync();
            return _mapper.Map<List<UserDto>>(book);
        }

        public async Task<UserDto> GetAddressByIdAsync(int AddressId)
        {
            var book = await _context.User_Details.FindAsync(AddressId);
            return _mapper.Map<UserDto>(book);
        }

        public int CountRecords()
        {
            return _context.User_Details.Count();
        }

        public async Task DeleteAddress(Guid Id)
        {
            var result = new User_Details()
            {
                Id = Id
            };
            _context.User_Details.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
