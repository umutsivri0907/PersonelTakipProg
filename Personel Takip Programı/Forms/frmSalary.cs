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
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void frmSalary_Load(object sender, EventArgs e)
        {
            GetEmployeeList("");
        }
        void GetEmployeeList(string searchText)
        {
            var employees = db.Employees.Where(s => s.Name.Contains(searchText) || s.Duty.Contains(searchText) || s.Email.Contains(searchText) || s.Phone.Contains(searchText)).ToList();
            dgEmployee.Rows.Clear();
            foreach (var employee in employees)
            {
                dgEmployee.Rows.Add(employee.Id, employee.Name, employee.Email, employee.Phone);
            }

        }
        void GetLeaveList(int employeeId)
        {

            var leaves = db.Leaves.Where(s => s.EmployeeId == employeeId).ToList();
            dgLeave.Rows.Clear();

            foreach (var leave in leaves)
            {
                dgLeave.Rows.Add(leave.Id, leave.Name, leave.Reason, leave.Employee.Name, leave.CreateDate.ToShortDateString());
            }
        }
        void GetSalaryList(int employeeId)
        {
            var salarys = db.Salaries.Where(s => s.EmployeeId == employeeId).ToList();
            dgSalary.Rows.Clear();
            foreach (var salary in salarys)
            {
                dgSalary.Rows.Add(salary.Id, salary.CreateDate.ToShortDateString(), salary.Paid);
            }

        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeId = Convert.ToInt32(dgEmployee.CurrentRow.Cells[0].Value.ToString());
            GetLeaveList(employeeId);
            GetSalaryList(employeeId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgEmployee.CurrentRow.Cells[0].Value.ToString());
            Salary salary = new Salary();

            salary.EmployeeId = employeeId;
            salary.Paid = Convert.ToDouble(txtPaid.Text);
            salary.CreateDate = dtDate.Value;
            salary.UpdateDate = dtDate.Value;
            db.Salaries.Add(salary);
            db.SaveChanges();
            GetSalaryList(employeeId);
            if (string.IsNullOrWhiteSpace(txtPaid.Text))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme miktarı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double paidAmount;
            if (!double.TryParse(txtPaid.Text, out paidAmount))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            salary.Paid = paidAmount;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetEmployeeList(txtSearch.Text);
        }
    }
}
