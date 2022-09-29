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
    public partial class ChangePasswordForm : Form
    {
        private readonly User _user;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
            this.loginLabel.Text = $"Логин: {user.Login}";
        }

        private void cnacelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!String.Equals(this.newPassTextBox.Text, this.confirmPassTextBox.Text))
            {
                MessageBox.Show("Пароли не совпадают","Ошибка");
            }
            else
            {
                _user.Password = this.newPassTextBox.Text;
                UsersAccountService.Users.Where(x => x.Login == _user.Login).Select(x => x.Password = _user.Password);
                MessageBox.Show("Пароль успешно изменен");
                this.Hide();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var progInfoForm = new ProgramInfoForm();
            progInfoForm.Show();
        }
    }
}
