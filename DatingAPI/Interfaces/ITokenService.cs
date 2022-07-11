using DatingAPI.Entities;
using DatingAPI.Interfaces;
using DatingAPI.Services;

namespace DatingAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}