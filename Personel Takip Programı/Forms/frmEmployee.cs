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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
        }
        void GetEmployeeList()
        {

            dgEmployee.Rows.Clear();
            var employees = db.Employees.ToList();

            foreach (var employee in employees)
            {
                dgEmployee.Rows.Add(employee.Id, employee.Name, employee.Duty, employee.Phone, employee.Email);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtDuty.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Employees.Count(c => c.Phone == txtPhone.Text) > 0)
            {
                MessageBox.Show("Girilen telefon numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var employee = new Employee();
            employee.Name = txtName.Text;
            employee.Duty = txtDuty.Text;
            employee.Phone = txtPhone.Text;
            employee.Email = txtEmail.Text;
            employee.CreateDate = DateTime.Now;
            employee.UpdateDate = DateTime.Now;

            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("personel eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetEmployeeList();
            btnClear.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtDuty.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var employee = db.Employees.Where(s => s.Id == id).SingleOrDefault();
            if (employee == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employee.Name = txtName.Text;
            employee.Duty = txtDuty.Text;
            employee.Phone = txtPhone.Text;

            db.Employees.Update(employee);
            db.SaveChanges();
            MessageBox.Show("Personel Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetEmployeeList();
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var employee = db.Employees.Where(s => s.Id == id).SingleOrDefault();
            if (employee == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Employees.Remove(employee);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetEmployeeList();
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgEmployee.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgEmployee.CurrentRow.Cells[1].Value.ToString();
            txtDuty.Text = dgEmployee.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgEmployee.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgEmployee.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
