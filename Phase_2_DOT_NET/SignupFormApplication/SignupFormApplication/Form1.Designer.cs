namespace SignupFormApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            confirmpassword = new Label();
            firstName = new TextBox();
            lastName = new TextBox();
            passwordInput = new TextBox();
            cpassword = new TextBox();
            emailInput = new TextBox();
            InsertData = new Button();
            ShowData = new Button();
            button3 = new Button();
            DeleteData = new Button();
            UserID = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Home = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(165, 62);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(154, 117);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(165, 178);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(165, 239);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // confirmpassword
            // 
            confirmpassword.AutoSize = true;
            confirmpassword.Font = new Font("Segoe UI", 12F);
            confirmpassword.Location = new Point(151, 300);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(206, 32);
            confirmpassword.TabIndex = 4;
            confirmpassword.Text = "Confirm password";
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 12F);
            firstName.Location = new Point(384, 55);
            firstName.Name = "firstName";
            firstName.Size = new Size(314, 39);
            firstName.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 12F);
            lastName.Location = new Point(384, 110);
            lastName.Name = "lastName";
            lastName.Size = new Size(314, 39);
            lastName.TabIndex = 7;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F);
            passwordInput.Location = new Point(384, 232);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(314, 39);
            passwordInput.TabIndex = 8;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // cpassword
            // 
            cpassword.Font = new Font("Segoe UI", 12F);
            cpassword.Location = new Point(384, 300);
            cpassword.Name = "cpassword";
            cpassword.Size = new Size(314, 39);
            cpassword.TabIndex = 9;
            cpassword.UseSystemPasswordChar = true;
            // 
            // emailInput
            // 
            emailInput.Font = new Font("Segoe UI", 12F);
            emailInput.Location = new Point(384, 171);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(314, 39);
            emailInput.TabIndex = 10;
            // 
            // InsertData
            // 
            InsertData.Font = new Font("Segoe UI", 12F);
            InsertData.Location = new Point(450, 392);
            InsertData.Name = "InsertData";
            InsertData.Size = new Size(115, 47);
            InsertData.TabIndex = 11;
            InsertData.Text = "Submit";
            InsertData.UseVisualStyleBackColor = true;
            InsertData.Click += InsertData_Click;
            // 
            // ShowData
            // 
            ShowData.Font = new Font("Segoe UI", 12F);
            ShowData.Location = new Point(262, 472);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(115, 47);
            ShowData.TabIndex = 12;
            ShowData.Text = "Show data";
            ShowData.UseVisualStyleBackColor = true;
            ShowData.Click += ShowData_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(450, 472);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DeleteData
            // 
            DeleteData.Font = new Font("Segoe UI", 12F);
            DeleteData.Location = new Point(634, 472);
            DeleteData.Name = "DeleteData";
            DeleteData.Size = new Size(115, 47);
            DeleteData.TabIndex = 14;
            DeleteData.Text = "Delete";
            DeleteData.UseVisualStyleBackColor = true;
            DeleteData.Click += DeleteData_Click;
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Location = new Point(191, 23);
            UserID.Name = "UserID";
            UserID.Size = new Size(70, 25);
            UserID.TabIndex = 15;
            UserID.Text = "User ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(384, 15);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(314, 31);
            numericUpDown1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(788, 313);
            dataGridView1.TabIndex = 17;
            // 
            // Home
            // 
            Home.Font = new Font("Segoe UI", 12F);
            Home.Location = new Point(110, 472);
            Home.Name = "Home";
            Home.Size = new Size(115, 47);
            Home.TabIndex = 19;
            Home.Text = "Add details";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(904, 556);
            Controls.Add(Home);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(UserID);
            Controls.Add(DeleteData);
            Controls.Add(button3);
            Controls.Add(ShowData);
            Controls.Add(InsertData);
            Controls.Add(emailInput);
            Controls.Add(cpassword);
            Controls.Add(passwordInput);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(confirmpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label confirmpassword;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox passwordInput;
        private TextBox cpassword;
        private TextBox emailInput;
        private Button InsertData;
        private Button ShowData;
        private Button button3;
        private Button DeleteData;
        private Label UserID;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Button Home;
    }
}
