using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Programı.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEmployee());
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLeave());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSalary());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

    }
}
