using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace CinemaManager.Main
{
    public class MyLoginForm : LoginForm
    {
        public MyLoginForm() : base("Kino - menedżer")
        { }


        override
        public void onLoginActionRequest(String login, String password)
        {
            Cursor.Current = Cursors.WaitCursor;
            CinemaModel.Employeers user = findUser(login, password);
            Cursor.Current = Cursors.Default;

            if (user == null)
                MessageBox.Show(new MessageStrings().NoSuchUser);
            else if (user.position != (int)EmployeeTypes.Types.Manager)
                MessageBox.Show(new MessageStrings().NoAccessAuthorization);
            else
                showMainForm();
        }

        private CinemaModel.Employeers findUser(String login, String password)
        {
            CinemaModel.Employeers user = null;
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                user = Queries.findUser(login, password, ctx);
            }
            return user;
        }

        private void showMainForm()
        {
            try
            {
                MainFormManager mainForm = new MainFormManager();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                String message = "Wystąpił nieobsłużony błąd: " + Environment.NewLine + ex.Message;
                MessageBox.Show(message);
            }
        }
    }
}
