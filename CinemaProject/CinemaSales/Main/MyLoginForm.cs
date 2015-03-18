using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace CinemaSales
{
    public class MyLoginForm : LoginForm
    {
        public MyLoginForm() : base("Kino - sprzedaż")
        {}

        override
        public void onLoginActionRequest(String login, String password)
        {
            Cursor.Current = Cursors.WaitCursor;
            CinemaModel.Employeers user = findUser(login, password);
            Cursor.Current = Cursors.Default;

            if (user == null)
                MessageBox.Show(new MessageStrings().NoSuchUser);
        }

        /*private void test()
        {
            Utils.ScenesCustomization sceneCustomization = new Utils.ScenesCustomization();
        }*/

        private CinemaModel.Employeers findUser(String login, String password)
        {
            CinemaModel.Employeers user = null;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var users = (from t in ctx.Employeers
                             where t.login.Equals(login)
                             && t.password.Equals(password)
                             select t);

                user = users.FirstOrDefault();
            }
            return user;
        }
    }
}
