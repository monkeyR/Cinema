using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Queries
    {
        public static CinemaModel.Employeers findUser(String login, String password, CinemaModel.CinemaDatabaseEntities ctx)
        {
            CinemaModel.Employeers user = null;

            var users = (from t in ctx.Employeers
                         where t.login.Equals(login)
                         && t.password.Equals(password)
                         select t);

            user = users.FirstOrDefault();
            return user;
        }
    }
}
