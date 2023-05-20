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
    public partial class employee_signup : Form
    {
        public employee_signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            int branch_num = Convert.ToInt32(branchNum);
            string  address = this.Address.Text;
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand commandSSN = connection.CreateCommand();
            commandSSN.CommandText = "SELECT * FROM EMPLOYEE";
            SqlDataReader reader = commandSSN.ExecuteReader();
            int EMP_ID = 0;

            while (reader.Read())
            {
                EMP_ID = (int)reader["EMP_ID"];
            }
            EMP_ID++;
            connection.Close();
            SqlConnection connection2 = new SqlConnection(connectionString);
            connection2.Open();
            SqlCommand command = connection2.CreateCommand();
            command.CommandText = "INSERT INTO EMPLOYEE VALUES(@EMP_ID, @BRANCH_NUM, @EMPLOYEE_NAME, @EMPLOYEE_ADDRESS)";
            command.Parameters.AddWithValue("@EMP_ID", EMP_ID);
            command.Parameters.AddWithValue("@BRANCH_NUM", branch_num);
            command.Parameters.AddWithValue("@EMPLOYEE_NAME", name);
            command.Parameters.AddWithValue("@EMPLOYEE_ADDRESS", address);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Information saved\tEmployee signed-up Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else
            {

            }
        }
    }
}
