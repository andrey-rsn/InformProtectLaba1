using InformProtectLaba1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformProtectLaba1
{
    public partial class FunctionsForm : Form
    {
        private readonly User _user;
        public FunctionsForm(User user)
        {
            InitializeComponent();
            _user= user;
            this.loginLabel.Text = $"Логин {user.Login}";
            this.roleLabel.Text = $"Роль {user.Role}";
            InitControls();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            var changePassForm = new ChangePasswordForm(_user);
            changePassForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void InitControls()
        {
            if (_user.Role == "user")
            {
                this.addUserBtn.Visible = false;
                this.modifyUsersBtn.Visible=false;
            }
        }

        private void modifyUsersBtn_Click(object sender, EventArgs e)
        {
            var userListForm = new UsersListForm();
            userListForm.Show();
        }
    }
}
