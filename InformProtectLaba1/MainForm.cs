using InformProtectLaba1.Sevices;

namespace InformProtectLaba1
{
    public partial class MainForm : Form
    {
        private int _tryCount=3;
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = UsersAccountService.Users.Where(x => String.Equals(x.Login, this.loginTextBox.Text) && String.Equals(x.Password, this.passwordTextBox.Text)).FirstOrDefault();
            if (user!=null)
            {
                if (user.isBlocked)
                {
                    MessageBox.Show("Данный пользователь заблокирован", "Ошибка");
                }
                else if (user.Role == "admin")
                {
                    var adminForm = new FunctionsForm(user);
                    adminForm.Show();
                    this.Hide();
                }
                else if(user.Role == "user")
                {
                    var userForm = new FunctionsForm(user);
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                _tryCount--;
                
                if(_tryCount == 0)
                {
                    Application.Exit();
                }
                MessageBox.Show($"Неправильный логин или пароль,попробуйте еще раз\nОсталось попыток: {_tryCount}","Ошибка авторизации");
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.passwordTextBox.UseSystemPasswordChar = !this.passwordTextBox.UseSystemPasswordChar;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var progInfoForm = new ProgramInfoForm();
            progInfoForm.Show();
        }
    }
}