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
        }

    }
}
