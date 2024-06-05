namespace Personel_Takip_Programı.Forms
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            txtDuty = new TextBox();
            txtId = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dgEmployee = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 385);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 107;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 343);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 27);
            txtEmail.TabIndex = 106;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 384);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 105;
            label7.Text = "E-Posta :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(183, 476);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 27);
            txtPhone.TabIndex = 104;
            // 
            // txtDuty
            // 
            txtDuty.Location = new Point(183, 423);
            txtDuty.Name = "txtDuty";
            txtDuty.Size = new Size(163, 27);
            txtDuty.TabIndex = 103;
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 301);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 27);
            txtId.TabIndex = 102;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 345);
            label8.Name = "label8";
            label8.Size = new Size(159, 25);
            label8.TabIndex = 101;
            label8.Text = "Cep Telefonu :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(83, 473);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 100;
            label9.Text = "Görevi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(42, 422);
            label10.Name = "label10";
            label10.Size = new Size(134, 25);
            label10.TabIndex = 99;
            label10.Text = "Adı Soyadı :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(29, 301);
            label11.Name = "label11";
            label11.Size = new Size(147, 25);
            label11.TabIndex = 98;
            label11.Text = "Personel No :";
            // 
            // dgEmployee
            // 
            dgEmployee.AllowUserToAddRows = false;
            dgEmployee.AllowUserToDeleteRows = false;
            dgEmployee.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, Column6 });
            dgEmployee.Location = new Point(29, 12);
            dgEmployee.Name = "dgEmployee";
            dgEmployee.ReadOnly = true;
            dgEmployee.RowHeadersWidth = 51;
            dgEmployee.RowTemplate.Height = 29;
            dgEmployee.Size = new Size(689, 230);
            dgEmployee.TabIndex = 97;
            dgEmployee.CellClick += dgEmployee_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Personel No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Görev";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Cep Telefon";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(852, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 60);
            btnClear.TabIndex = 96;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(694, 438);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 60);
            btnUpdate.TabIndex = 95;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(224, 224, 224);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(852, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 57);
            btnDelete.TabIndex = 94;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(694, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 54);
            btnSave.TabIndex = 93;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1224, 543);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(txtDuty);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dgEmployee);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployee";
            Text = "frmEmployee";
            WindowState = FormWindowState.Maximized;
            Load += frmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPhone;
        private TextBox txtDuty;
        private TextBox txtId;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView dgEmployee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
    }
}