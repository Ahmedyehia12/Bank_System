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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BANK_APP_GUI
{
    public partial class addBranch : Form
    {
        private string branchAddress;
        private int bankCode;
        public addBranch()
        {
            InitializeComponent();
        }

        private void addBranch_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            branchAddress = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);

            int branchNum = getBranchNum();

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO BRANCH (BANK_CODE, BRANCH_NUM, BRANCH_ADDRESS) " +
                "VALUES (@BANK_CODE, @BRANCH_NUM, @BRANCH_ADDRESS)";
            command.Parameters.AddWithValue("@BANK_CODE", bankCode);
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            command.Parameters.AddWithValue("@BRANCH_ADDRESS", branchAddress);

            command.ExecuteNonQuery();
            connection.Close();
            numericUpDown1.ResetText();
            textBox2.Clear();
            MessageBox.Show("Branch Added Successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new admin_interface();
            newframe.Show();
            Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bankCode = (int)numericUpDown1.Value;
        }

        public static int getBranchNum()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int branchNum = 0;
            SqlCommand commandSSN = connection.CreateCommand();
            commandSSN.CommandText = "SELECT MAX(BRANCH_NUM) AS MaxNum FROM BRANCH";
            SqlDataReader reader = commandSSN.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxNum")))
                {
                    branchNum = (int)reader["MaxNum"];
                }
            }

            reader.Close();
            connection.Close();

            return branchNum + 1;
        }
    }
}
