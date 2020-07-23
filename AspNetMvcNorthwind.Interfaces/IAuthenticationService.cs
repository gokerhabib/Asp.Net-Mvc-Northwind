using System.ServiceModel;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User Authenticate(User user);
    }
}