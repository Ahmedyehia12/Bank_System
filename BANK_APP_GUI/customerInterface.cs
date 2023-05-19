using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class customerInterface : Form
    {
        public int ssn;
        public customerInterface(int ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestLoan requestLoan = new requestLoan(ssn);
            requestLoan.Show();
            this.Hide();
            }
    }
}
