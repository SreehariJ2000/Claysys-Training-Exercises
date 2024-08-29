namespace WinFormsApplication
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
            username = new TextBox();
            password = new TextBox();
            label2 = new Label();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 135);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            username.Location = new Point(241, 135);
            username.Name = "username";
            username.Size = new Size(356, 31);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(241, 210);
            password.Name = "password";
            password.Size = new Size(357, 31);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 210);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // submit
            // 
            submit.Location = new Point(371, 305);
            submit.Name = "submit";
            submit.Size = new Size(112, 34);
            submit.TabIndex = 4;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 450);
            Controls.Add(submit);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SampleForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username;
        private TextBox password;
        private Label label2;
        private Button submit;
    }
}
