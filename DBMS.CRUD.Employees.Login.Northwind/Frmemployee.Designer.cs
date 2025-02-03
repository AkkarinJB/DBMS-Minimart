namespace DBMS.CRUD.Employees.Login.Northwind
{
    partial class Frmemployee
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
            dgvEmployee = new DataGridView();
            btnCreata = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(776, 238);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            dgvEmployee.CellMouseUp += dgvEmployee_CellMouseUp;
            // 
            // btnCreata
            // 
            btnCreata.Location = new Point(81, 348);
            btnCreata.Name = "btnCreata";
            btnCreata.Size = new Size(131, 55);
            btnCreata.TabIndex = 1;
            btnCreata.Text = "เพิ่ม";
            btnCreata.UseVisualStyleBackColor = true;
            btnCreata.Click += btnCreata_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(242, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 55);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "เเก้ไข";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(433, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 55);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Frmemployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreata);
            Controls.Add(dgvEmployee);
            Name = "Frmemployee";
            Text = "Frmemployee";
            Load += Frmemployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private Button btnCreata;
        private Button btnUpdate;
        private Button btnDelete;
    }
}