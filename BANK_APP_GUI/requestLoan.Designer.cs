namespace BANK_APP_GUI
{
    partial class requestLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            customerBranch = new TextBox();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            customerAccount = new TextBox();
            label5 = new Label();
            amount = new TextBox();
            button1 = new Button();
            label6 = new Label();
            loanType = new TextBox();
            button2 = new Button();
            button6 = new Button();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(399, 155);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 63);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Your Branches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(214, 340);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 2;
            label2.Text = "Choose Branch:";
            // 
            // customerBranch
            // 
            customerBranch.Location = new Point(369, 335);
            customerBranch.Name = "customerBranch";
            customerBranch.Size = new Size(191, 27);
            customerBranch.TabIndex = 3;
            customerBranch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(483, 104);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(457, 155);
            dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(483, 63);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 5;
            label3.Text = "Your Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(214, 395);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 6;
            label4.Text = "Choose Account";
            // 
            // customerAccount
            // 
            customerAccount.Location = new Point(369, 389);
            customerAccount.Name = "customerAccount";
            customerAccount.Size = new Size(191, 27);
            customerAccount.TabIndex = 7;
            customerAccount.TextChanged += customerAccount_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(215, 503);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 8;
            label5.Text = "Enter Amount:";
            // 
            // amount
            // 
            amount.Location = new Point(370, 497);
            amount.Name = "amount";
            amount.Size = new Size(193, 27);
            amount.TabIndex = 9;
            amount.TextChanged += amount_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(383, 573);
            button1.Name = "button1";
            button1.Size = new Size(117, 53);
            button1.TabIndex = 10;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(215, 448);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 11;
            label6.Text = "Enter Loan Type";
            // 
            // loanType
            // 
            loanType.Location = new Point(370, 443);
            loanType.Name = "loanType";
            loanType.Size = new Size(191, 27);
            loanType.TabIndex = 12;
            loanType.TextChanged += loanType_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(880, 627);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(67, 35);
            button2.TabIndex = 20;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(14, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
            button6.TabIndex = 21;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Maroon;
            errorLabel.Location = new Point(383, 642);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 20);
            errorLabel.TabIndex = 22;
            // 
            // requestLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(961, 677);
            Controls.Add(errorLabel);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(loanType);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(amount);
            Controls.Add(label5);
            Controls.Add(customerAccount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(customerBranch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "requestLoan";
            Text = "requestLoan";
            Load += requestLoan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox customerBranch;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private TextBox customerAccount;
        private Label label5;
        private TextBox amount;
        private Button button1;
        private Label label6;
        private TextBox loanType;
        private Button button2;
        private Button button6;
        private Label errorLabel;
    }
}