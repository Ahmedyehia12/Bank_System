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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(372, 144);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Your Branches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 2;
            label2.Text = "Choose Branch:";
            // 
            // customerBranch
            // 
            customerBranch.Location = new Point(12, 237);
            customerBranch.Name = "customerBranch";
            customerBranch.Size = new Size(192, 27);
            customerBranch.TabIndex = 3;
            customerBranch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 309);
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
            label3.Location = new Point(11, 283);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 5;
            label3.Text = "Your Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 478);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 6;
            label4.Text = "Choose Account";
            // 
            // customerAccount
            // 
            customerAccount.Location = new Point(12, 504);
            customerAccount.Name = "customerAccount";
            customerAccount.Size = new Size(192, 27);
            customerAccount.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 615);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 8;
            label5.Text = "Enter Amount:";
            // 
            // amount
            // 
            amount.Location = new Point(11, 654);
            amount.Name = "amount";
            amount.Size = new Size(193, 27);
            amount.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(289, 673);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
            button1.TabIndex = 10;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 549);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 11;
            label6.Text = "Enter Loan Type";
            // 
            // loanType
            // 
            loanType.Location = new Point(12, 575);
            loanType.Name = "loanType";
            loanType.Size = new Size(192, 27);
            loanType.TabIndex = 12;
            // 
            // requestLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 730);
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
    }
}