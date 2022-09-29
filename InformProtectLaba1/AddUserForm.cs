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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.loginTextBox.Text))
            {
                MessageBox.Show("Введите имя пользователя", "Внимание");
            }
            else if (!UsersAccountService.Users.Where(x => x.Login == this.loginTextBox.Text).Any())
            {
                UsersAccountService.Users.Add(new Data.User()
                {
                    Login = this.loginTextBox.Text,
                    Password="",
                    Id= UsersAccountService.Users.Last().Id+1,
                    isBlocked=false,
                    isPasswordConstraint=true,
                    Role="user"

                });
                this.Hide();
                MessageBox.Show($"Пользователь с именем {this.loginTextBox.Text} успешно добавлен", "Внимание");
            }
            else
            {
                MessageBox.Show($"Пользователь с именем {this.loginTextBox.Text} уже существует, выберите другое", "Внимание");
            }
        }
    }
}
