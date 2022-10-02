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
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UsersAccountService.ReadDataFromFile(this.textBox1.Text);
                if (!UsersAccountService.Users.Where(x => x.Login == "admin").Any())
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    var mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var progInfoForm = new ProgramInfoForm();
            progInfoForm.Show();
        }
    }
}
