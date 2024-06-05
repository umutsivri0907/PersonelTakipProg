using Personel_Takip_Programı.Models;
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
    public partial class frmLeave : Form
    {
        public frmLeave()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void frmLeave_Load(object sender, EventArgs e)
        {

            GetLeaveList();
            GetEmployeeList();
            dgEmployee.Visible = false;
        }
        void GetLeaveList()
        {

            var leaves = db.Leaves.ToList();
            dgLeave.Rows.Clear();

            foreach (var leave in leaves)
            {
                var employeeName = leave.Employee;
                dgLeave.Rows.Add(leave.Id, leave.Name, leave.Reason, employeeName);

            }
        }
        void GetEmployeeList()
        {

            var employees = db.Employees.ToList();
            dgEmployee.Rows.Clear();

            foreach (var employee in employees)
            {
                dgEmployee.Rows.Add(employee.Id, employee.Name, employee.Duty, employee.Phone, employee.Email);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgEmployee.Visible = true;
            dgLeave.Visible = false;
        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Leave leave = new Leave();

            leave.Reason = txtReason.Text;
            leave.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);

            leave.CreateDate = dtDate.Value;
            leave.UpdateDate = dtDate.Value;

            MessageBox.Show("İzin Kaydı Yapılmıştır", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }

            }
            dgEmployee.Visible = false;
            dgLeave.Visible = true;
        }

        private void dgEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeId.Text = dgEmployee.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgEmployee.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgEmployee.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgEmployee.CurrentRow.Cells[3].Value.ToString();


            dgEmployee.Visible = false;
            dgLeave.Visible = true;
        }
    }
}
