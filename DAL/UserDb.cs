using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDb : DALBase
    {
       
        public List<Users> GetAllUser()
        {
            var _userList = db.Users.ToList();
            return _userList;
        }
    }
}
