using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Interfaces
{
    public interface IAuthenticationService
    {
        User Authenticate(User user);
    }
}