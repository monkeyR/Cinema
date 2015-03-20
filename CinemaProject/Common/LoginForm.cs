using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public abstract partial class LoginForm : Form
    {

        public LoginForm(String formTitle)
        {
            InitializeComponent();
            SetupTitle(formTitle);
        }

        private void SetupTitle(String formTitle)
        {
            this.Text = formTitle;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (preValidate())
                onLoginActionRequest(loginTextBox.Text, passwordTextBox.Text);
        }

        private bool preValidate()
        {
            if(loginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Login nie może być pusty.");
                return false;
            }
            return true;
        }

        public abstract void onLoginActionRequest(String login, String password);

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (preValidate())
                    onLoginActionRequest(loginTextBox.Text, passwordTextBox.Text);
            }
        }

    }
}
