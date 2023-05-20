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
    public partial class displayAllCustomers : Form
    {
        public displayAllCustomers()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayAllCustomers_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CUSTOMER", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "CUSTOMER");
            dataGridView1.DataSource = ds.Tables["CUSTOMER"].DefaultView;
        }

        private void displayAllLoan()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAN", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "LOAN");
            dataGridView1.DataSource = ds.Tables["LOAN"].DefaultView;
        }

        private void displayLoanSpecial()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            string query = "SELECT LOAN_NUM, LOAN_TYPE, LOAN_AMOUNT, CUSTOMER_NAME, EMP_NAME FROM LOAN JOIN CUSTOMER ON LOAN.SSN = CUSTOMER.SSN JOIN EMPLOYEE ON LOAN.EMP_ID = EMPLOYEE.EMP_ID";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "LOAN");
            dataGridView1.DataSource = ds.Tables["LOAN"].DefaultView;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new admin_interface();
            newframe.Show();
            Visible = false;
        }
    }
}
