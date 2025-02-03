namespace DBMS.CRUD.Employees.Login.Northwind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnEmployee = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnLogout = new Button();
            btnLogin = new Button();
            btnOrders = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnOrders);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEmployee);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(113, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 373);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "จัดการข้อมูล";
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(42, 22);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(187, 66);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Empolyee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 94);
            button4.Name = "button4";
            button4.Size = new Size(187, 66);
            button4.TabIndex = 4;
            button4.Text = "Customer";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(42, 166);
            button3.Name = "button3";
            button3.Size = new Size(187, 66);
            button3.TabIndex = 3;
            button3.Text = "Suppliers";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(42, 238);
            button2.Name = "button2";
            button2.Size = new Size(187, 66);
            button2.TabIndex = 2;
            button2.Text = "Shippers";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(472, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(69, 33);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(397, 26);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(69, 33);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(42, 307);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(187, 60);
            btnOrders.TabIndex = 9;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnEmployee;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnLogout;
        private Button btnLogin;
        private Button btnOrders;
    }
}
