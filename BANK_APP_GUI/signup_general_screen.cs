namespace BANK_APP_GUI
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newframe = new customer_signup();
            newframe.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newframe = new employee_signup();
            newframe.Show();
            Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new homePage();
            newframe.Show();
            Visible = false;

        }
    }
}