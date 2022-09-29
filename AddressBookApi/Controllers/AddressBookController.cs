using AutoMapper;
using Contracts;
using Entities.Dto;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookService _addressBookService;
        private readonly IMapper _mapper;

        public AddressBookController(IAddressBookService AddressBookService, IMapper mapper)
        {
            _addressBookService = AddressBookService;
            _mapper = mapper;
        }

        /*[HttpPost("RefSet")]
        public ActionResult<RefSetDto> CreateRefSet([FromBody] RefSetDto refsetdto)
        {
            var result = _addressBookService.AddRefSet(refsetdto);
            return new JsonResult(result);
            var bandEntity = _mapper.Map<Entities.Band>(band);
            _bandAlbumRepository.AddBand(bandEntity);
            _bandAlbumRepository.Save();

        }*/

        [HttpPost]
        public ActionResult<UserDto> CreateBand([FromBody] UserForCreatingDto user)
        {
            var bandEntity = _mapper.Map<User_Details>(user);
            _addressBookService.AddBand(bandEntity);
            _addressBookService.Save();

            var bandToReturn = _mapper.Map<UserDto>(bandEntity);

            return CreatedAtRoute("GetBand", new { bandId = bandToReturn.Id }, bandToReturn);
        }

        [HttpPost("RefSet")]
        public ActionResult<RefSetDto> CreateRefSet([FromBody] RefSetDto refsetdto)
        {
            var result = _addressBookService.AddRefSet(refsetdto);
            return new JsonResult(result);
        }

        [HttpPost("RefTerm")]
        public ActionResult<RefTermDto> CreateRefTerm([FromBody] RefTermDto reftermdto)
        {
            var result = _addressBookService.AddRefTerm(reftermdto);
            return new JsonResult(result);
        }

        [HttpGet("GetAllAddress")]
        public  ActionResult GetAllAddress()
        {
            var address = _addressBookService.GetAllAddress();
            return Ok(address);
        }

        [HttpGet("{Id}")]
        public ActionResult GetAddressById([FromRoute] int Id)
        {
            var address = _addressBookService.GetAddressByIdAsync(Id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }

        [HttpGet("Count")]
        public IActionResult CountRecords()
        {
            var result = _addressBookService.CountRecords();
            return Ok(result);
        }

        [HttpDelete("DeleteAddress")]
        public IActionResult DeleteAddress([FromRoute] Guid Id)
        {
            _addressBookService.DeleteAddress(Id);
            return Ok();
        }
    }
}
