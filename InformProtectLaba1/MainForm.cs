using InformProtectLaba1.Sevices;

namespace InformProtectLaba1
{
    public partial class MainForm : Form
    {
        private readonly UsersAccountService _accountService;
        public MainForm()
        {
            InitializeComponent();
            _accountService = new();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _accountService.Users.Where(x => String.Equals(x.Login, this.loginTextBox.Text) && String.Equals(x.Password, this.passwordTextBox.Text)).FirstOrDefault();
            if (user!=null)
            {
                if (user.Role == "admin")
                {
                    var adminForm = new FunctionsForm(user);
                    adminForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.passwordTextBox.UseSystemPasswordChar = !this.passwordTextBox.UseSystemPasswordChar;
        }
    }
}