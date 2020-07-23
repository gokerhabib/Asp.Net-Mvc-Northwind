using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Dal.Abstract;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Dal.Concrete.EntityFramework
{
    public class EfAuthenticationDal : IAuthenticationDal
    {
        private NorthwindContext _context = new NorthwindContext();
        public User Authenticate(User user)
        {
            var _user = _context.Users.FirstOrDefault(a => a.UserName == user.UserName && a.Password == user.Password);
            return _user ?? null;
        }
    }
}
