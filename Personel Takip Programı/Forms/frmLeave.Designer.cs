namespace Personel_Takip_Programı.Forms
{
    partial class frmLeave
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
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtName = new TextBox();
            label9 = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label3 = new Label();
            dtDate = new DateTimePicker();
            txtReason = new TextBox();
            txtEmployeeId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgEmployee = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dgLeave = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dtEndDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLeave).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 27);
            txtEmail.TabIndex = 126;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 278);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 125;
            label5.Text = "E-Posta :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 511);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 124;
            label4.Text = " Bitiş Tarihi :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(143, 348);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(186, 27);
            txtPhone.TabIndex = 122;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(32, 348);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 23);
            label10.TabIndex = 121;
            label10.Text = "Telefonu :";
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 312);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(182, 27);
            txtName.TabIndex = 120;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(33, 309);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 119;
            label9.Text = "Adı Soyadı :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(481, 302);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 36);
            btnSearch.TabIndex = 118;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(937, 293);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 39);
            btnClear.TabIndex = 117;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(791, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 37);
            btnSave.TabIndex = 116;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 465);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 115;
            label3.Text = " Başlangıç Tarihi :";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(188, 461);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 27);
            dtDate.TabIndex = 114;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(143, 380);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(186, 66);
            txtReason.TabIndex = 113;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(147, 247);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(182, 27);
            txtEmployeeId.TabIndex = 112;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 390);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 111;
            label2.Text = "İzin Sebebi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 247);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 110;
            label1.Text = "Personel No :";
            // 
            // dgEmployee
            // 
            dgEmployee.AllowUserToAddRows = false;
            dgEmployee.AllowUserToDeleteRows = false;
            dgEmployee.BackgroundColor = Color.FromArgb(255, 128, 128);
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, Column6 });
            dgEmployee.Location = new Point(532, 26);
            dgEmployee.Name = "dgEmployee";
            dgEmployee.ReadOnly = true;
            dgEmployee.RowHeadersWidth = 51;
            dgEmployee.RowTemplate.Height = 29;
            dgEmployee.Size = new Size(689, 230);
            dgEmployee.TabIndex = 109;
            dgEmployee.CellClick += dgEmployee_CellClick;
            dgEmployee.CellDoubleClick += dgEmployee_CellDoubleClick;
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
            // dgLeave
            // 
            dgLeave.AllowUserToDeleteRows = false;
            dgLeave.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgLeave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLeave.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column2 });
            dgLeave.Location = new Point(2, 12);
            dgLeave.Name = "dgLeave";
            dgLeave.ReadOnly = true;
            dgLeave.RowHeadersWidth = 51;
            dgLeave.RowTemplate.Height = 29;
            dgLeave.Size = new Size(524, 214);
            dgLeave.TabIndex = 108;
            // 
            // Column1
            // 
            Column1.HeaderText = "Personel No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Adı Soyadı";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tarih";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "İzin Sebebi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(188, 508);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(250, 27);
            dtEndDate.TabIndex = 127;
            // 
            // frmLeave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1241, 561);
            Controls.Add(dtEndDate);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(dtDate);
            Controls.Add(txtReason);
            Controls.Add(txtEmployeeId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgEmployee);
            Controls.Add(dgLeave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLeave";
            Text = "frmLeave";
            WindowState = FormWindowState.Maximized;
            Load += frmLeave_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLeave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        public TextBox txtPhone;
        private Label label10;
        public TextBox txtName;
        private Label label9;
        private Button btnSearch;
        private Button btnClear;
        private Button btnSave;
        private Label label3;
        private DateTimePicker dtDate;
        private TextBox txtReason;
        private TextBox txtEmployeeId;
        private Label label2;
        private Label label1;
        private DataGridView dgEmployee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView dgLeave;
        private DateTimePicker dtEndDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}