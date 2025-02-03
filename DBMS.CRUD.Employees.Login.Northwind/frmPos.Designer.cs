
using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS.CRUD.Employees.Login.Northwind
{
    partial class frmPos
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtTotal = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            lsvProducts = new ListView();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblNetPrice = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(109, 61);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(100, 23);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.TextChanged += txtEmployeeID_TextChanged;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown_1;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(313, 61);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(197, 23);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(469, 53);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(112, 53);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(158, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(6, 53);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 23);
            txtProductID.TabIndex = 4;
            txtProductID.TextChanged += txtProductID_TextChanged;
            txtProductID.KeyDown += txtProductID_KeyDown_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(382, 53);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(81, 23);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(276, 53);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(21, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 7;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(250, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "ชื่อ-สกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "รหัสสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 35);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "ชื่อสินค้า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 35);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 11;
            label5.Text = "ราคาขาย";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 35);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 12;
            label6.Text = "จำนวน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 35);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "รวมเป็นเงิน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(698, 9);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 14;
            label8.Text = "รวมเป็นเงิน";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProducts);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Location = new Point(12, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 296);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อ";
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(6, 82);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(563, 204);
            lsvProducts.TabIndex = 14;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.SelectedIndexChanged += lsvProduct_SelectedIndexChanged;
            lsvProducts.DoubleClick += lsvProduct_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(651, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 38);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "เพิ่มรายการ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.Location = new Point(651, 223);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 36);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(637, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 18;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button3_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(637, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 43);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "ยกเลิกรายการสั่งซื้อ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNetPrice
            // 
            lblNetPrice.AutoSize = true;
            lblNetPrice.BackColor = Color.Blue;
            lblNetPrice.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.ForeColor = SystemColors.ButtonHighlight;
            lblNetPrice.Location = new Point(582, 32);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(195, 47);
            lblNetPrice.TabIndex = 20;
            lblNetPrice.Text = "lblNetPrice";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lsvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select EmployeeID,titleOfCourtesy+FirstName+ SPACE(2)+ LastName as empName"
                + " , title from employees where employeeID = @employeeID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtEmployeeID.Text = dt.Rows[0][0].ToString();
                    txtEmployeeName.Text = dt.Rows[0][1].ToString();
                    txtProductID.Focus();
                }
                else
                {
                    clearEmployeeData();
                    txtEmployeeName.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtTotal;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private ListView lsvProducts;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNetPrice;
    }
}