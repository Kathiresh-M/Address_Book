

using Entities.Dto;

namespace Contracts
{
    public interface IJWTManagerRepository
    {
        DataTokensMetadata Authenticate(UserDto user);
    }
}
