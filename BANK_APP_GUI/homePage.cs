namespace BANK_APP_GUI
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // sign up
        private void button1_Click(object sender, EventArgs e)
        {
            var newframe = new sign_up();
            newframe.Show();
            Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// sign in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var newframe = new signin();
            newframe.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using our App!");
            Close();
        }
    }
}