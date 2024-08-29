namespace WinFormsApplication
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            if (Username == "sree" && Password == "sree")
            {

                MessageBox.Show("Login successful! Welcome, " + Username);
            }
            else
            {

                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
