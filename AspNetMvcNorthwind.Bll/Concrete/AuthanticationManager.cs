using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Dal.Abstract;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.Bll.Concrete
{
    public class AuthanticationManager : IAuthenticationService
    {
        private IAuthenticationDal _authenticationDal;

        public AuthanticationManager(IAuthenticationDal authenticationDal)
        {
            _authenticationDal = authenticationDal;
        }

        public User Authenticate(User user)
        {
           return _authenticationDal.Authenticate(user);
        }
    }
}
