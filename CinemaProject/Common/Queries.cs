using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Queries
    {
        public static CinemaModel.Employees findUser(String login, String password, CinemaModel.CinemaDatabaseEntities ctx)
        {
            CinemaModel.Employees user = null;

            var users = (from t in ctx.Employees
                         where t.login.CompareTo(login) == 0
                         && t.password.CompareTo(password) == 0
                         select t);

            user = users.FirstOrDefault();
            return user;
        }
    }
}
