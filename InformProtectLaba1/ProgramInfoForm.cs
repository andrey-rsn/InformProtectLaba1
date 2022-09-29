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
    public partial class ProgramInfoForm : Form
    {
        public ProgramInfoForm()
        {
            InitializeComponent();
            this.AuthorInfo.Text = ProgramInfo.Autor;
            this.TaskInfo.Text = ProgramInfo.TaskInfo;
        }
    }
}
