using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Bll.Concrete;
using AspNetMvcNorthwind.Dal.Concrete.EntityFramework;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.WcfLibrary.Concrete
{
    class AuthenticationService : IAuthenticationService
    {
        AuthanticationManager _authanticationManager = new AuthanticationManager(new EfAuthenticationDal());
        public User Authenticate(User user)
        {
            return _authanticationManager.Authenticate(user);
        }
    }
}
