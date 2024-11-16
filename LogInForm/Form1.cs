namespace LogInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Successfully Logged In!!");
            }
            else {
                MessageBox.Show("Error");
            }
        }
    }
}
