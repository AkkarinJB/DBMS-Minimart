namespace DBMS.CRUD.Employees.Login.Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.Login_status == "pass")
            {
                this.Text = "โปรแกรม Northwind รหัส : " + f.employeeID.ToString();
                this.Text += " ชื่อ-สกุล : " + f.employeeName + " ตำแหน่ง : " + f.employeeTitle;
                groupBox1.Visible = true;
                btnLogout.Visible = true;
                btnLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Text = "โปรแกรม Northwind";
            groupBox1.Visible = false;
            btnLogout.Visible = false;
            btnLogin.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Frmemployee em = new Frmemployee();
            em.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmPos pos = new frmPos();
            pos.ShowDialog();
        }
    }
}
