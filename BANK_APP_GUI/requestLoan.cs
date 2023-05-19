using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class requestLoan : Form
    {
        public int ssn;
        public requestLoan(int ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SERVES , BRANCH , BANK WHERE SERVES.SSN = 1  and  SERVES.BRANCH_NUM = BRANCH.BRANCH_NUM and BRANCH.BANK_CODE = BANK.BANK_CODE", connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
               }
            catch
            {
                MessageBox.Show("Error");

            }


        }
        public static void displayCustomerBranches(int ssn)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SERVES JOIN BRANCH ON SERVES.BRANCH_NUM = BRANCH.BRANCH_NUM JOIN BANK ON BRANCH.BANK_CODE = BANK.BANK_CODE";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Your branches: ");
            while (reader.Read())
            {
                // write in form's datagridview
                // 


            }
            reader.Close();
        }
    }
}
