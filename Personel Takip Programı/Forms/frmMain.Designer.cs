namespace Personel_Takip_Programı.Forms
{
    partial class frmMain
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
            panel2 = new Panel();
            btnExit = new Button();
            btnSalary = new Button();
            btnLeave = new Button();
            btnEmployee = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSalary);
            panel2.Controls.Add(btnLeave);
            panel2.Controls.Add(btnEmployee);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 549);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 192, 255);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(26, 434);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 90);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(192, 192, 255);
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalary.Location = new Point(26, 291);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(183, 92);
            btnSalary.TabIndex = 3;
            btnSalary.Text = "Maaş";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(192, 192, 255);
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLeave.Location = new Point(26, 157);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(183, 88);
            btnLeave.TabIndex = 2;
            btnLeave.Text = "İzin";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(192, 192, 255);
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Location = new Point(26, 32);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(183, 83);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Personel";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 125);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(607, 68);
            label1.TabIndex = 1;
            label1.Text = "Personel Takip Sistemi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1201, 424);
            panel3.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 549);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Button btnSalary;
        private Button btnLeave;
        private Button btnEmployee;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
    }
}