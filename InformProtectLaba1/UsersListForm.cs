using InformProtectLaba1.Data;
using InformProtectLaba1.Sevices;
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
    public partial class UsersListForm : Form
    {
        private int index = 0;
        public UsersListForm()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void UpdateControls()
        {
            this.prevBtn.Enabled = !(index==0); 
            this.nextBtn.Enabled = !(index == UsersAccountService.Users.Count-1);
            this.loginTextBox.Text = UsersAccountService.Users[index].Login;
            this.isBlocked.Checked= UsersAccountService.Users[index].isBlocked;
            this.isPasswordConstraint.Checked= UsersAccountService.Users[index].isPasswordConstraint;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            index++;
            UpdateControls();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            index--;
            UpdateControls();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.loginTextBox.Text))
            {
                MessageBox.Show("Некорректный формат имя пользователя", "Внимание");
            }
            else if (!String.Equals(this.loginTextBox.Text, UsersAccountService.Users[index].Login)&&UsersAccountService.Users.Where(x=>x.Login==this.loginTextBox.Text).Any()) 
            {
                MessageBox.Show("Пользователь с таким именем уже существует, попробуйте другое", "Внимание");
            }
            else
            {
                var modifiedUser = UsersAccountService.Users[index];
                modifiedUser.Login = this.loginTextBox.Text;
                modifiedUser.isPasswordConstraint = this.isPasswordConstraint.Checked;
                modifiedUser.isBlocked = this.isBlocked.Checked;
                UsersAccountService.Users.Select(x=>x=modifiedUser);
                MessageBox.Show("Изменения успешно сохранены");
            }
        }
    }
}
