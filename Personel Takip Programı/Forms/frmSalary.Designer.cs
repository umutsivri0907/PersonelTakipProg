namespace Personel_Takip_Programı.Forms
{
    partial class frmSalary
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
            txtSearch = new TextBox();
            label1 = new Label();
            txtPaid = new TextBox();
            label8 = new Label();
            dtDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dgEmployee = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            dgSalary = new DataGridView();
            dgLeave = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLeave).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtSearch.Location = new Point(270, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 27);
            txtSearch.TabIndex = 116;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(226, 330);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 115;
            label1.Text = "TL";
            // 
            // txtPaid
            // 
            txtPaid.Location = new Point(91, 327);
            txtPaid.Margin = new Padding(2);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(98, 27);
            txtPaid.TabIndex = 114;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(6, 332);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 23);
            label8.TabIndex = 113;
            label8.Text = "Ödeme";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(91, 279);
            dtDate.Margin = new Padding(2);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(241, 27);
            dtDate.TabIndex = 112;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(2, 283);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 111;
            label3.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(0, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 23);
            label4.TabIndex = 110;
            label4.Text = "Aramak için bir değer giriniz";
            // 
            // dgEmployee
            // 
            dgEmployee.AllowUserToAddRows = false;
            dgEmployee.AllowUserToDeleteRows = false;
            dgEmployee.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgEmployee.Location = new Point(588, 11);
            dgEmployee.Name = "dgEmployee";
            dgEmployee.ReadOnly = true;
            dgEmployee.RowHeadersWidth = 51;
            dgEmployee.RowTemplate.Height = 29;
            dgEmployee.Size = new Size(643, 230);
            dgEmployee.TabIndex = 109;
            dgEmployee.CellClick += dgEmployee_CellClick;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Personel No";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Görev";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Cep Telefon";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(349, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 107;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgSalary
            // 
            dgSalary.AllowUserToDeleteRows = false;
            dgSalary.BackgroundColor = Color.RosyBrown;
            dgSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSalary.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dgSalary.GridColor = Color.FromArgb(255, 255, 128);
            dgSalary.Location = new Point(6, 48);
            dgSalary.Name = "dgSalary";
            dgSalary.ReadOnly = true;
            dgSalary.RowHeadersWidth = 51;
            dgSalary.RowTemplate.Height = 29;
            dgSalary.Size = new Size(444, 175);
            dgSalary.TabIndex = 106;
            // 
            // dgLeave
            // 
            dgLeave.AllowUserToDeleteRows = false;
            dgLeave.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgLeave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLeave.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn11 });
            dgLeave.Location = new Point(604, 256);
            dgLeave.Name = "dgLeave";
            dgLeave.ReadOnly = true;
            dgLeave.RowHeadersWidth = 51;
            dgLeave.RowTemplate.Height = 29;
            dgLeave.Size = new Size(524, 214);
            dgLeave.TabIndex = 117;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Personel No";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Tarih";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "İzin Sebebi";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Personel No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ödeme Tarihi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Miktar";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1249, 573);
            Controls.Add(dgLeave);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(txtPaid);
            Controls.Add(label8);
            Controls.Add(dtDate);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dgEmployee);
            Controls.Add(btnSave);
            Controls.Add(dgSalary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSalary";
            Text = "frmSalary";
            WindowState = FormWindowState.Maximized;
            Load += frmSalary_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLeave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private TextBox txtPaid;
        private Label label8;
        private DateTimePicker dtDate;
        private Label label3;
        private Label label4;
        private DataGridView dgEmployee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnSave;
        private DataGridView dgSalary;
        private DataGridView dgLeave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}